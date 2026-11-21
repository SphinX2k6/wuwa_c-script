using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017C RID: 380
	[NetMessage(EMessageId.BattlePassTaskTakeResponse)]
	public sealed class BattlePassTaskTakeResponse : IMessage<BattlePassTaskTakeResponse>, IMessage, IEquatable<BattlePassTaskTakeResponse>, IDeepCloneable<BattlePassTaskTakeResponse>, IBufferMessage
	{
		// Token: 0x06002E72 RID: 11890 RVA: 0x00077E7C File Offset: 0x0007607C
		[NullableContext(1)]
		public static BattlePassTaskTakeResponse Create()
		{
			return new BattlePassTaskTakeResponse();
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00077E83 File Offset: 0x00076083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x00077E86 File Offset: 0x00076086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskTakeResponse.Descriptor;
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00077E8D File Offset: 0x0007608D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse()
		{
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00077EA0 File Offset: 0x000760A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse(BattlePassTaskTakeResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00077ED6 File Offset: 0x000760D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse Clone()
		{
			return new BattlePassTaskTakeResponse(this);
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00077EDE File Offset: 0x000760DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00077EE6 File Offset: 0x000760E6
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00077EEE File Offset: 0x000760EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00077EF7 File Offset: 0x000760F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskTakeResponse);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00077F08 File Offset: 0x00076108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskTakeResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00077F58 File Offset: 0x00076158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00077FAB File Offset: 0x000761AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00077FB8 File Offset: 0x000761B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00077FC4 File Offset: 0x000761C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, BattlePassTaskTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00078014 File Offset: 0x00076214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(BattlePassTaskTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00078068 File Offset: 0x00076268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000780B5 File Offset: 0x000762B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000780C0 File Offset: 0x000762C0
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
				if (num != 80U && num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, BattlePassTaskTakeResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040028CB RID: 10443
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028CC RID: 10444
		public const int IdsFieldNumber = 10;

		// Token: 0x040028CD RID: 10445
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040028CE RID: 10446
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x040028CF RID: 10447
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040028D0 RID: 10448
		private ErrorCode errorCode_;
	}
}
