using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117A RID: 4474
	[NetMessage(EMessageId.RunTurntableActivityResponse)]
	public sealed class RunTurntableActivityResponse : IMessage<RunTurntableActivityResponse>, IMessage, IEquatable<RunTurntableActivityResponse>, IDeepCloneable<RunTurntableActivityResponse>, IBufferMessage
	{
		// Token: 0x06017E5F RID: 97887 RVA: 0x0037A67C File Offset: 0x0037887C
		[NullableContext(1)]
		public static RunTurntableActivityResponse Create()
		{
			return new RunTurntableActivityResponse();
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x06017E60 RID: 97888 RVA: 0x0037A683 File Offset: 0x00378883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x06017E61 RID: 97889 RVA: 0x0037A686 File Offset: 0x00378886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTurntableActivityResponse.Descriptor;
			}
		}

		// Token: 0x06017E62 RID: 97890 RVA: 0x0037A68D File Offset: 0x0037888D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityResponse()
		{
		}

		// Token: 0x06017E63 RID: 97891 RVA: 0x0037A6A0 File Offset: 0x003788A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityResponse(RunTurntableActivityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardId_ = other.rewardId_;
			this.isFinishCurRound_ = other.isFinishCurRound_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E64 RID: 97892 RVA: 0x0037A6F9 File Offset: 0x003788F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityResponse Clone()
		{
			return new RunTurntableActivityResponse(this);
		}

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x06017E65 RID: 97893 RVA: 0x0037A701 File Offset: 0x00378901
		// (set) Token: 0x06017E66 RID: 97894 RVA: 0x0037A709 File Offset: 0x00378909
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

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x06017E67 RID: 97895 RVA: 0x0037A712 File Offset: 0x00378912
		// (set) Token: 0x06017E68 RID: 97896 RVA: 0x0037A71A File Offset: 0x0037891A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x06017E69 RID: 97897 RVA: 0x0037A723 File Offset: 0x00378923
		// (set) Token: 0x06017E6A RID: 97898 RVA: 0x0037A72B File Offset: 0x0037892B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinishCurRound
		{
			get
			{
				return this.isFinishCurRound_;
			}
			set
			{
				this.isFinishCurRound_ = value;
			}
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x06017E6B RID: 97899 RVA: 0x0037A734 File Offset: 0x00378934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06017E6C RID: 97900 RVA: 0x0037A73C File Offset: 0x0037893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTurntableActivityResponse);
		}

		// Token: 0x06017E6D RID: 97901 RVA: 0x0037A74C File Offset: 0x0037894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTurntableActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardId == other.RewardId && this.IsFinishCurRound == other.IsFinishCurRound && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E6E RID: 97902 RVA: 0x0037A7BC File Offset: 0x003789BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this.IsFinishCurRound)
			{
				num ^= this.IsFinishCurRound.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E6F RID: 97903 RVA: 0x0037A841 File Offset: 0x00378A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E70 RID: 97904 RVA: 0x0037A84E File Offset: 0x00378A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E71 RID: 97905 RVA: 0x0037A858 File Offset: 0x00378A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsFinishCurRound)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsFinishCurRound);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RewardId);
			}
			this.itemMap_.WriteTo(ref output, RunTurntableActivityResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E72 RID: 97906 RVA: 0x0037A8E0 File Offset: 0x00378AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this.IsFinishCurRound)
			{
				num += 2;
			}
			num += this.itemMap_.CalculateSize(RunTurntableActivityResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x0037A958 File Offset: 0x00378B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTurntableActivityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			if (other.IsFinishCurRound)
			{
				this.IsFinishCurRound = other.IsFinishCurRound;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E74 RID: 97908 RVA: 0x0037A9CD File Offset: 0x00378BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E75 RID: 97909 RVA: 0x0037A9D8 File Offset: 0x00378BD8
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
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.IsFinishCurRound = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.RewardId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.itemMap_.AddEntriesFrom(ref input, RunTurntableActivityResponse._map_itemMap_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E6B RID: 36459
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E6C RID: 36460
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008E6D RID: 36461
		private ErrorCode errorCode_;

		// Token: 0x04008E6E RID: 36462
		public const int RewardIdFieldNumber = 13;

		// Token: 0x04008E6F RID: 36463
		private int rewardId_;

		// Token: 0x04008E70 RID: 36464
		public const int IsFinishCurRoundFieldNumber = 9;

		// Token: 0x04008E71 RID: 36465
		private bool isFinishCurRound_;

		// Token: 0x04008E72 RID: 36466
		public const int ItemMapFieldNumber = 14;

		// Token: 0x04008E73 RID: 36467
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04008E74 RID: 36468
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
