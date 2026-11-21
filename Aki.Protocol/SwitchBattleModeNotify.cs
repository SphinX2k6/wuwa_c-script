using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001365 RID: 4965
	[NetMessage(EMessageId.SwitchBattleModeNotify)]
	public sealed class SwitchBattleModeNotify : IMessage<SwitchBattleModeNotify>, IMessage, IEquatable<SwitchBattleModeNotify>, IDeepCloneable<SwitchBattleModeNotify>, IBufferMessage
	{
		// Token: 0x0601A71D RID: 108317 RVA: 0x003DA72E File Offset: 0x003D892E
		[NullableContext(1)]
		public static SwitchBattleModeNotify Create()
		{
			return new SwitchBattleModeNotify();
		}

		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x0601A71E RID: 108318 RVA: 0x003DA735 File Offset: 0x003D8935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x0601A71F RID: 108319 RVA: 0x003DA738 File Offset: 0x003D8938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeNotify.Descriptor;
			}
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x003DA73F File Offset: 0x003D893F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify()
		{
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x003DA75D File Offset: 0x003D895D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify(SwitchBattleModeNotify other) : this()
		{
			this.serverControllerModules_ = other.serverControllerModules_.Clone();
			this.clientControllerModules_ = other.clientControllerModules_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A722 RID: 108322 RVA: 0x003DA798 File Offset: 0x003D8998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify Clone()
		{
			return new SwitchBattleModeNotify(this);
		}

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x0601A723 RID: 108323 RVA: 0x003DA7A0 File Offset: 0x003D89A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleModule> ServerControllerModules
		{
			get
			{
				return this.serverControllerModules_;
			}
		}

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x0601A724 RID: 108324 RVA: 0x003DA7A8 File Offset: 0x003D89A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleModule> ClientControllerModules
		{
			get
			{
				return this.clientControllerModules_;
			}
		}

		// Token: 0x0601A725 RID: 108325 RVA: 0x003DA7B0 File Offset: 0x003D89B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeNotify);
		}

		// Token: 0x0601A726 RID: 108326 RVA: 0x003DA7C0 File Offset: 0x003D89C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeNotify other)
		{
			return other != null && (other == this || (this.serverControllerModules_.Equals(other.serverControllerModules_) && this.clientControllerModules_.Equals(other.clientControllerModules_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A727 RID: 108327 RVA: 0x003DA814 File Offset: 0x003D8A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.serverControllerModules_.GetHashCode();
			num ^= this.clientControllerModules_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A728 RID: 108328 RVA: 0x003DA856 File Offset: 0x003D8A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A729 RID: 108329 RVA: 0x003DA863 File Offset: 0x003D8A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A72A RID: 108330 RVA: 0x003DA86C File Offset: 0x003D8A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.serverControllerModules_.WriteTo(ref output, SwitchBattleModeNotify._repeated_serverControllerModules_codec);
			this.clientControllerModules_.WriteTo(ref output, SwitchBattleModeNotify._repeated_clientControllerModules_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A72B RID: 108331 RVA: 0x003DA8A4 File Offset: 0x003D8AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.serverControllerModules_.CalculateSize(SwitchBattleModeNotify._repeated_serverControllerModules_codec);
			num += this.clientControllerModules_.CalculateSize(SwitchBattleModeNotify._repeated_clientControllerModules_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A72C RID: 108332 RVA: 0x003DA8F0 File Offset: 0x003D8AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchBattleModeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.serverControllerModules_.Add(other.serverControllerModules_);
			this.clientControllerModules_.Add(other.clientControllerModules_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A72D RID: 108333 RVA: 0x003DA92F File Offset: 0x003D8B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A72E RID: 108334 RVA: 0x003DA938 File Offset: 0x003D8B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.serverControllerModules_.AddEntriesFrom(ref input, SwitchBattleModeNotify._repeated_serverControllerModules_codec);
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.clientControllerModules_.AddEntriesFrom(ref input, SwitchBattleModeNotify._repeated_clientControllerModules_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B27 RID: 39719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B28 RID: 39720
		public const int ServerControllerModulesFieldNumber = 4;

		// Token: 0x04009B29 RID: 39721
		private static readonly FieldCodec<BattleModule> _repeated_serverControllerModules_codec = FieldCodec.ForEnum<BattleModule>(34U, (BattleModule x) => (int)x, (int x) => (BattleModule)x);

		// Token: 0x04009B2A RID: 39722
		private readonly RepeatedField<BattleModule> serverControllerModules_ = new RepeatedField<BattleModule>();

		// Token: 0x04009B2B RID: 39723
		public const int ClientControllerModulesFieldNumber = 13;

		// Token: 0x04009B2C RID: 39724
		private static readonly FieldCodec<BattleModule> _repeated_clientControllerModules_codec = FieldCodec.ForEnum<BattleModule>(106U, (BattleModule x) => (int)x, (int x) => (BattleModule)x);

		// Token: 0x04009B2D RID: 39725
		private readonly RepeatedField<BattleModule> clientControllerModules_ = new RepeatedField<BattleModule>();
	}
}
