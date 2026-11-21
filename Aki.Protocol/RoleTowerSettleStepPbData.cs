using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EC RID: 4332
	public sealed class RoleTowerSettleStepPbData : IMessage<RoleTowerSettleStepPbData>, IMessage, IEquatable<RoleTowerSettleStepPbData>, IDeepCloneable<RoleTowerSettleStepPbData>, IBufferMessage
	{
		// Token: 0x0601727E RID: 94846 RVA: 0x0035E448 File Offset: 0x0035C648
		[NullableContext(1)]
		public static RoleTowerSettleStepPbData Create()
		{
			return new RoleTowerSettleStepPbData();
		}

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x0601727F RID: 94847 RVA: 0x0035E44F File Offset: 0x0035C64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x06017280 RID: 94848 RVA: 0x0035E452 File Offset: 0x0035C652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerSettleStepPbData.Descriptor;
			}
		}

		// Token: 0x06017281 RID: 94849 RVA: 0x0035E459 File Offset: 0x0035C659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleStepPbData()
		{
		}

		// Token: 0x06017282 RID: 94850 RVA: 0x0035E461 File Offset: 0x0035C661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleStepPbData(RoleTowerSettleStepPbData other) : this()
		{
			this.stageSettleInfo_ = ((other.stageSettleInfo_ != null) ? other.stageSettleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017283 RID: 94851 RVA: 0x0035E496 File Offset: 0x0035C696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleStepPbData Clone()
		{
			return new RoleTowerSettleStepPbData(this);
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x06017284 RID: 94852 RVA: 0x0035E49E File Offset: 0x0035C69E
		// (set) Token: 0x06017285 RID: 94853 RVA: 0x0035E4A6 File Offset: 0x0035C6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleStepPbData StageSettleInfo
		{
			get
			{
				return this.stageSettleInfo_;
			}
			set
			{
				this.stageSettleInfo_ = value;
			}
		}

		// Token: 0x06017286 RID: 94854 RVA: 0x0035E4AF File Offset: 0x0035C6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerSettleStepPbData);
		}

		// Token: 0x06017287 RID: 94855 RVA: 0x0035E4BD File Offset: 0x0035C6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerSettleStepPbData other)
		{
			return other != null && (other == this || (object.Equals(this.StageSettleInfo, other.StageSettleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017288 RID: 94856 RVA: 0x0035E4F0 File Offset: 0x0035C6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stageSettleInfo_ != null)
			{
				num ^= this.StageSettleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017289 RID: 94857 RVA: 0x0035E52C File Offset: 0x0035C72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601728A RID: 94858 RVA: 0x0035E539 File Offset: 0x0035C739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601728B RID: 94859 RVA: 0x0035E542 File Offset: 0x0035C742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stageSettleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.StageSettleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x0035E574 File Offset: 0x0035C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stageSettleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageSettleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x0035E5B4 File Offset: 0x0035C7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerSettleStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageSettleInfo_ != null)
			{
				if (this.stageSettleInfo_ == null)
				{
					this.StageSettleInfo = new SettleStepPbData();
				}
				this.StageSettleInfo.MergeFrom(other.StageSettleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x0035E608 File Offset: 0x0035C808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601728F RID: 94863 RVA: 0x0035E614 File Offset: 0x0035C814
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.stageSettleInfo_ == null)
					{
						this.StageSettleInfo = new SettleStepPbData();
					}
					input.ReadMessage(this.StageSettleInfo);
				}
			}
		}

		// Token: 0x04008A86 RID: 35462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A87 RID: 35463
		public const int StageSettleInfoFieldNumber = 1;

		// Token: 0x04008A88 RID: 35464
		private SettleStepPbData stageSettleInfo_;
	}
}
