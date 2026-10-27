using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F7 RID: 4855
	[NetMessage(EMessageId.SwitchBattleModeRequest)]
	public sealed class SwitchBattleModeRequest : IMessage<SwitchBattleModeRequest>, IMessage, IEquatable<SwitchBattleModeRequest>, IDeepCloneable<SwitchBattleModeRequest>, IBufferMessage
	{
		// Token: 0x06019CFA RID: 105722 RVA: 0x003C02F1 File Offset: 0x003BE4F1
		[NullableContext(1)]
		public static SwitchBattleModeRequest Create()
		{
			return new SwitchBattleModeRequest();
		}

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x06019CFB RID: 105723 RVA: 0x003C02F8 File Offset: 0x003BE4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x06019CFC RID: 105724 RVA: 0x003C02FB File Offset: 0x003BE4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeRequest.Descriptor;
			}
		}

		// Token: 0x06019CFD RID: 105725 RVA: 0x003C0302 File Offset: 0x003BE502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest()
		{
		}

		// Token: 0x06019CFE RID: 105726 RVA: 0x003C030A File Offset: 0x003BE50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest(SwitchBattleModeRequest other) : this()
		{
			this.client_ = other.client_;
			this.clientControllerModule_ = other.clientControllerModule_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CFF RID: 105727 RVA: 0x003C033B File Offset: 0x003BE53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest Clone()
		{
			return new SwitchBattleModeRequest(this);
		}

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x06019D00 RID: 105728 RVA: 0x003C0343 File Offset: 0x003BE543
		// (set) Token: 0x06019D01 RID: 105729 RVA: 0x003C034B File Offset: 0x003BE54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Client
		{
			get
			{
				return this.client_;
			}
			set
			{
				this.client_ = value;
			}
		}

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x06019D02 RID: 105730 RVA: 0x003C0354 File Offset: 0x003BE554
		// (set) Token: 0x06019D03 RID: 105731 RVA: 0x003C035C File Offset: 0x003BE55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleModule ClientControllerModule
		{
			get
			{
				return this.clientControllerModule_;
			}
			set
			{
				this.clientControllerModule_ = value;
			}
		}

		// Token: 0x06019D04 RID: 105732 RVA: 0x003C0365 File Offset: 0x003BE565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeRequest);
		}

		// Token: 0x06019D05 RID: 105733 RVA: 0x003C0373 File Offset: 0x003BE573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeRequest other)
		{
			return other != null && (other == this || (this.Client == other.Client && this.ClientControllerModule == other.ClientControllerModule && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D06 RID: 105734 RVA: 0x003C03B4 File Offset: 0x003BE5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Client)
			{
				num ^= this.Client.GetHashCode();
			}
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				num ^= this.ClientControllerModule.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D07 RID: 105735 RVA: 0x003C0412 File Offset: 0x003BE612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D08 RID: 105736 RVA: 0x003C041F File Offset: 0x003BE61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D09 RID: 105737 RVA: 0x003C0428 File Offset: 0x003BE628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ClientControllerModule);
			}
			if (this.Client)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Client);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D0A RID: 105738 RVA: 0x003C0484 File Offset: 0x003BE684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Client)
			{
				num += 2;
			}
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ClientControllerModule);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D0B RID: 105739 RVA: 0x003C04D0 File Offset: 0x003BE6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchBattleModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Client)
			{
				this.Client = other.Client;
			}
			if (other.ClientControllerModule != BattleModule.Damage)
			{
				this.ClientControllerModule = other.ClientControllerModule;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D0C RID: 105740 RVA: 0x003C0520 File Offset: 0x003BE720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D0D RID: 105741 RVA: 0x003C052C File Offset: 0x003BE72C
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Client = input.ReadBool();
					}
				}
				else
				{
					this.ClientControllerModule = (BattleModule)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009704 RID: 38660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009705 RID: 38661
		public const int ClientFieldNumber = 12;

		// Token: 0x04009706 RID: 38662
		private bool client_;

		// Token: 0x04009707 RID: 38663
		public const int ClientControllerModuleFieldNumber = 11;

		// Token: 0x04009708 RID: 38664
		private BattleModule clientControllerModule_;
	}
}
