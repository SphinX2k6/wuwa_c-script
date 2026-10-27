using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F6 RID: 4854
	[NetMessage(EMessageId.SwitchBattleModeNotify)]
	public sealed class SwitchBattleModeNotify : IMessage<SwitchBattleModeNotify>, IMessage, IEquatable<SwitchBattleModeNotify>, IDeepCloneable<SwitchBattleModeNotify>, IBufferMessage
	{
		// Token: 0x06019CE7 RID: 105703 RVA: 0x003C000E File Offset: 0x003BE20E
		[NullableContext(1)]
		public static SwitchBattleModeNotify Create()
		{
			return new SwitchBattleModeNotify();
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x06019CE8 RID: 105704 RVA: 0x003C0015 File Offset: 0x003BE215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x06019CE9 RID: 105705 RVA: 0x003C0018 File Offset: 0x003BE218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeNotify.Descriptor;
			}
		}

		// Token: 0x06019CEA RID: 105706 RVA: 0x003C001F File Offset: 0x003BE21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify()
		{
		}

		// Token: 0x06019CEB RID: 105707 RVA: 0x003C003D File Offset: 0x003BE23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify(SwitchBattleModeNotify other) : this()
		{
			this.serverControllerModules_ = other.serverControllerModules_.Clone();
			this.clientControllerModules_ = other.clientControllerModules_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CEC RID: 105708 RVA: 0x003C0078 File Offset: 0x003BE278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeNotify Clone()
		{
			return new SwitchBattleModeNotify(this);
		}

		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x06019CED RID: 105709 RVA: 0x003C0080 File Offset: 0x003BE280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleModule> ServerControllerModules
		{
			get
			{
				return this.serverControllerModules_;
			}
		}

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x06019CEE RID: 105710 RVA: 0x003C0088 File Offset: 0x003BE288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleModule> ClientControllerModules
		{
			get
			{
				return this.clientControllerModules_;
			}
		}

		// Token: 0x06019CEF RID: 105711 RVA: 0x003C0090 File Offset: 0x003BE290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeNotify);
		}

		// Token: 0x06019CF0 RID: 105712 RVA: 0x003C00A0 File Offset: 0x003BE2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeNotify other)
		{
			return other != null && (other == this || (this.serverControllerModules_.Equals(other.serverControllerModules_) && this.clientControllerModules_.Equals(other.clientControllerModules_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CF1 RID: 105713 RVA: 0x003C00F4 File Offset: 0x003BE2F4
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

		// Token: 0x06019CF2 RID: 105714 RVA: 0x003C0136 File Offset: 0x003BE336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CF3 RID: 105715 RVA: 0x003C0143 File Offset: 0x003BE343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CF4 RID: 105716 RVA: 0x003C014C File Offset: 0x003BE34C
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

		// Token: 0x06019CF5 RID: 105717 RVA: 0x003C0184 File Offset: 0x003BE384
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

		// Token: 0x06019CF6 RID: 105718 RVA: 0x003C01D0 File Offset: 0x003BE3D0
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

		// Token: 0x06019CF7 RID: 105719 RVA: 0x003C020F File Offset: 0x003BE40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CF8 RID: 105720 RVA: 0x003C0218 File Offset: 0x003BE418
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.serverControllerModules_.AddEntriesFrom(ref input, SwitchBattleModeNotify._repeated_serverControllerModules_codec);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.clientControllerModules_.AddEntriesFrom(ref input, SwitchBattleModeNotify._repeated_clientControllerModules_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096FD RID: 38653
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096FE RID: 38654
		public const int ServerControllerModulesFieldNumber = 1;

		// Token: 0x040096FF RID: 38655
		private static readonly FieldCodec<BattleModule> _repeated_serverControllerModules_codec = FieldCodec.ForEnum<BattleModule>(10U, (BattleModule x) => (int)x, (int x) => (BattleModule)x);

		// Token: 0x04009700 RID: 38656
		private readonly RepeatedField<BattleModule> serverControllerModules_ = new RepeatedField<BattleModule>();

		// Token: 0x04009701 RID: 38657
		public const int ClientControllerModulesFieldNumber = 3;

		// Token: 0x04009702 RID: 38658
		private static readonly FieldCodec<BattleModule> _repeated_clientControllerModules_codec = FieldCodec.ForEnum<BattleModule>(26U, (BattleModule x) => (int)x, (int x) => (BattleModule)x);

		// Token: 0x04009703 RID: 38659
		private readonly RepeatedField<BattleModule> clientControllerModules_ = new RepeatedField<BattleModule>();
	}
}
