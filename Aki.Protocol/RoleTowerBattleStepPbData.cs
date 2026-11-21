using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BA RID: 4282
	public sealed class RoleTowerBattleStepPbData : IMessage<RoleTowerBattleStepPbData>, IMessage, IEquatable<RoleTowerBattleStepPbData>, IDeepCloneable<RoleTowerBattleStepPbData>, IBufferMessage
	{
		// Token: 0x06016E15 RID: 93717 RVA: 0x0035325B File Offset: 0x0035145B
		[NullableContext(1)]
		public static RoleTowerBattleStepPbData Create()
		{
			return new RoleTowerBattleStepPbData();
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x06016E16 RID: 93718 RVA: 0x00353262 File Offset: 0x00351462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x06016E17 RID: 93719 RVA: 0x00353265 File Offset: 0x00351465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerBattleStepPbData.Descriptor;
			}
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x0035326C File Offset: 0x0035146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBattleStepPbData()
		{
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x00353274 File Offset: 0x00351474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBattleStepPbData(RoleTowerBattleStepPbData other) : this()
		{
			this.timeData_ = ((other.timeData_ != null) ? other.timeData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x003532A9 File Offset: 0x003514A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBattleStepPbData Clone()
		{
			return new RoleTowerBattleStepPbData(this);
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x06016E1B RID: 93723 RVA: 0x003532B1 File Offset: 0x003514B1
		// (set) Token: 0x06016E1C RID: 93724 RVA: 0x003532B9 File Offset: 0x003514B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData TimeData
		{
			get
			{
				return this.timeData_;
			}
			set
			{
				this.timeData_ = value;
			}
		}

		// Token: 0x06016E1D RID: 93725 RVA: 0x003532C2 File Offset: 0x003514C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerBattleStepPbData);
		}

		// Token: 0x06016E1E RID: 93726 RVA: 0x003532D0 File Offset: 0x003514D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerBattleStepPbData other)
		{
			return other != null && (other == this || (object.Equals(this.TimeData, other.TimeData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E1F RID: 93727 RVA: 0x00353304 File Offset: 0x00351504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.timeData_ != null)
			{
				num ^= this.TimeData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x00353340 File Offset: 0x00351540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E21 RID: 93729 RVA: 0x0035334D File Offset: 0x0035154D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E22 RID: 93730 RVA: 0x00353356 File Offset: 0x00351556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.timeData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TimeData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E23 RID: 93731 RVA: 0x00353388 File Offset: 0x00351588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.timeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimeData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E24 RID: 93732 RVA: 0x003533C8 File Offset: 0x003515C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerBattleStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.timeData_ != null)
			{
				if (this.timeData_ == null)
				{
					this.TimeData = new RoleTowerTimerData();
				}
				this.TimeData.MergeFrom(other.TimeData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E25 RID: 93733 RVA: 0x0035341C File Offset: 0x0035161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E26 RID: 93734 RVA: 0x00353428 File Offset: 0x00351628
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
					if (this.timeData_ == null)
					{
						this.TimeData = new RoleTowerTimerData();
					}
					input.ReadMessage(this.TimeData);
				}
			}
		}

		// Token: 0x040088DC RID: 35036
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088DD RID: 35037
		public const int TimeDataFieldNumber = 1;

		// Token: 0x040088DE RID: 35038
		private RoleTowerTimerData timeData_;
	}
}
