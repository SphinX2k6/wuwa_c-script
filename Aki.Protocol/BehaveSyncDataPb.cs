using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000198 RID: 408
	public sealed class BehaveSyncDataPb : IMessage<BehaveSyncDataPb>, IMessage, IEquatable<BehaveSyncDataPb>, IDeepCloneable<BehaveSyncDataPb>, IBufferMessage
	{
		// Token: 0x0600309C RID: 12444 RVA: 0x0007C4C8 File Offset: 0x0007A6C8
		[NullableContext(1)]
		public static BehaveSyncDataPb Create()
		{
			return new BehaveSyncDataPb();
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x0007C4CF File Offset: 0x0007A6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x0007C4D2 File Offset: 0x0007A6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaveSyncDataPb.Descriptor;
			}
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0007C4D9 File Offset: 0x0007A6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaveSyncDataPb()
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0007C4E1 File Offset: 0x0007A6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaveSyncDataPb(BehaveSyncDataPb other) : this()
		{
			this.behaviorId_ = other.behaviorId_;
			this.isSuccess_ = other.isSuccess_;
			this.specialState_ = other.specialState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x0007C51E File Offset: 0x0007A71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaveSyncDataPb Clone()
		{
			return new BehaveSyncDataPb(this);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x0007C526 File Offset: 0x0007A726
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x0007C52E File Offset: 0x0007A72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BehaviorId
		{
			get
			{
				return this.behaviorId_;
			}
			set
			{
				this.behaviorId_ = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0007C537 File Offset: 0x0007A737
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x0007C53F File Offset: 0x0007A73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x0007C548 File Offset: 0x0007A748
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x0007C550 File Offset: 0x0007A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpecialState
		{
			get
			{
				return this.specialState_;
			}
			set
			{
				this.specialState_ = value;
			}
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0007C559 File Offset: 0x0007A759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaveSyncDataPb);
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0007C568 File Offset: 0x0007A768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaveSyncDataPb other)
		{
			return other != null && (other == this || (this.BehaviorId == other.BehaviorId && this.IsSuccess == other.IsSuccess && this.SpecialState == other.SpecialState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0007C5C4 File Offset: 0x0007A7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BehaviorId != 0)
			{
				num ^= this.BehaviorId.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.SpecialState != 0)
			{
				num ^= this.SpecialState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0007C635 File Offset: 0x0007A835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0007C642 File Offset: 0x0007A842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0007C64C File Offset: 0x0007A84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BehaviorId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BehaviorId);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSuccess);
			}
			if (this.SpecialState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SpecialState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0007C6C0 File Offset: 0x0007A8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BehaviorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BehaviorId);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.SpecialState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpecialState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0007C724 File Offset: 0x0007A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BehaveSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BehaviorId != 0)
			{
				this.BehaviorId = other.BehaviorId;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.SpecialState != 0)
			{
				this.SpecialState = other.SpecialState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0007C788 File Offset: 0x0007A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0007C794 File Offset: 0x0007A994
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SpecialState = input.ReadInt32();
						}
					}
					else
					{
						this.IsSuccess = input.ReadBool();
					}
				}
				else
				{
					this.BehaviorId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002953 RID: 10579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002954 RID: 10580
		public const int BehaviorIdFieldNumber = 1;

		// Token: 0x04002955 RID: 10581
		private int behaviorId_;

		// Token: 0x04002956 RID: 10582
		public const int IsSuccessFieldNumber = 2;

		// Token: 0x04002957 RID: 10583
		private bool isSuccess_;

		// Token: 0x04002958 RID: 10584
		public const int SpecialStateFieldNumber = 4;

		// Token: 0x04002959 RID: 10585
		private int specialState_;
	}
}
