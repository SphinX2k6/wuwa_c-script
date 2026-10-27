using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001140 RID: 4416
	[NetMessage(EMessageId.RunTurntableActivityResponse)]
	public sealed class RunTurntableActivityResponse : IMessage<RunTurntableActivityResponse>, IMessage, IEquatable<RunTurntableActivityResponse>, IDeepCloneable<RunTurntableActivityResponse>, IBufferMessage
	{
		// Token: 0x060178BE RID: 96446 RVA: 0x0036B331 File Offset: 0x00369531
		[NullableContext(1)]
		public static RunTurntableActivityResponse Create()
		{
			return new RunTurntableActivityResponse();
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x060178BF RID: 96447 RVA: 0x0036B338 File Offset: 0x00369538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x060178C0 RID: 96448 RVA: 0x0036B33B File Offset: 0x0036953B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTurntableActivityResponse.Descriptor;
			}
		}

		// Token: 0x060178C1 RID: 96449 RVA: 0x0036B342 File Offset: 0x00369542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityResponse()
		{
		}

		// Token: 0x060178C2 RID: 96450 RVA: 0x0036B358 File Offset: 0x00369558
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

		// Token: 0x060178C3 RID: 96451 RVA: 0x0036B3B1 File Offset: 0x003695B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityResponse Clone()
		{
			return new RunTurntableActivityResponse(this);
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x060178C4 RID: 96452 RVA: 0x0036B3B9 File Offset: 0x003695B9
		// (set) Token: 0x060178C5 RID: 96453 RVA: 0x0036B3C1 File Offset: 0x003695C1
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

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x060178C6 RID: 96454 RVA: 0x0036B3CA File Offset: 0x003695CA
		// (set) Token: 0x060178C7 RID: 96455 RVA: 0x0036B3D2 File Offset: 0x003695D2
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

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x060178C8 RID: 96456 RVA: 0x0036B3DB File Offset: 0x003695DB
		// (set) Token: 0x060178C9 RID: 96457 RVA: 0x0036B3E3 File Offset: 0x003695E3
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

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x060178CA RID: 96458 RVA: 0x0036B3EC File Offset: 0x003695EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x060178CB RID: 96459 RVA: 0x0036B3F4 File Offset: 0x003695F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTurntableActivityResponse);
		}

		// Token: 0x060178CC RID: 96460 RVA: 0x0036B404 File Offset: 0x00369604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTurntableActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardId == other.RewardId && this.IsFinishCurRound == other.IsFinishCurRound && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178CD RID: 96461 RVA: 0x0036B474 File Offset: 0x00369674
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

		// Token: 0x060178CE RID: 96462 RVA: 0x0036B4F9 File Offset: 0x003696F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178CF RID: 96463 RVA: 0x0036B506 File Offset: 0x00369706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178D0 RID: 96464 RVA: 0x0036B510 File Offset: 0x00369710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RewardId);
			}
			this.itemMap_.WriteTo(ref output, RunTurntableActivityResponse._map_itemMap_codec);
			if (this.IsFinishCurRound)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsFinishCurRound);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178D1 RID: 96465 RVA: 0x0036B598 File Offset: 0x00369798
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

		// Token: 0x060178D2 RID: 96466 RVA: 0x0036B610 File Offset: 0x00369810
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

		// Token: 0x060178D3 RID: 96467 RVA: 0x0036B685 File Offset: 0x00369885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178D4 RID: 96468 RVA: 0x0036B690 File Offset: 0x00369890
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
				if (num <= 50U)
				{
					if (num == 32U)
					{
						this.RewardId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.itemMap_.AddEntriesFrom(ref input, RunTurntableActivityResponse._map_itemMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsFinishCurRound = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008BD8 RID: 35800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD9 RID: 35801
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008BDA RID: 35802
		private ErrorCode errorCode_;

		// Token: 0x04008BDB RID: 35803
		public const int RewardIdFieldNumber = 4;

		// Token: 0x04008BDC RID: 35804
		private int rewardId_;

		// Token: 0x04008BDD RID: 35805
		public const int IsFinishCurRoundFieldNumber = 8;

		// Token: 0x04008BDE RID: 35806
		private bool isFinishCurRound_;

		// Token: 0x04008BDF RID: 35807
		public const int ItemMapFieldNumber = 6;

		// Token: 0x04008BE0 RID: 35808
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x04008BE1 RID: 35809
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
