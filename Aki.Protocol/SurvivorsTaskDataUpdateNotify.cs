using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135C RID: 4956
	[NetMessage(EMessageId.SurvivorsTaskDataUpdateNotify)]
	public sealed class SurvivorsTaskDataUpdateNotify : IMessage<SurvivorsTaskDataUpdateNotify>, IMessage, IEquatable<SurvivorsTaskDataUpdateNotify>, IDeepCloneable<SurvivorsTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A672 RID: 108146 RVA: 0x003D9201 File Offset: 0x003D7401
		[NullableContext(1)]
		public static SurvivorsTaskDataUpdateNotify Create()
		{
			return new SurvivorsTaskDataUpdateNotify();
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x0601A673 RID: 108147 RVA: 0x003D9208 File Offset: 0x003D7408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x0601A674 RID: 108148 RVA: 0x003D920B File Offset: 0x003D740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A675 RID: 108149 RVA: 0x003D9212 File Offset: 0x003D7412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify()
		{
		}

		// Token: 0x0601A676 RID: 108150 RVA: 0x003D921A File Offset: 0x003D741A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify(SurvivorsTaskDataUpdateNotify other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A677 RID: 108151 RVA: 0x003D924F File Offset: 0x003D744F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify Clone()
		{
			return new SurvivorsTaskDataUpdateNotify(this);
		}

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x0601A678 RID: 108152 RVA: 0x003D9257 File Offset: 0x003D7457
		// (set) Token: 0x0601A679 RID: 108153 RVA: 0x003D925F File Offset: 0x003D745F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskData
		{
			get
			{
				return this.activityTaskData_;
			}
			set
			{
				this.activityTaskData_ = value;
			}
		}

		// Token: 0x0601A67A RID: 108154 RVA: 0x003D9268 File Offset: 0x003D7468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTaskDataUpdateNotify);
		}

		// Token: 0x0601A67B RID: 108155 RVA: 0x003D9276 File Offset: 0x003D7476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A67C RID: 108156 RVA: 0x003D92AC File Offset: 0x003D74AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTaskData_ != null)
			{
				num ^= this.ActivityTaskData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A67D RID: 108157 RVA: 0x003D92E8 File Offset: 0x003D74E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A67E RID: 108158 RVA: 0x003D92F5 File Offset: 0x003D74F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A67F RID: 108159 RVA: 0x003D92FE File Offset: 0x003D74FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A680 RID: 108160 RVA: 0x003D9330 File Offset: 0x003D7530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A681 RID: 108161 RVA: 0x003D9370 File Offset: 0x003D7570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTaskData_ != null)
			{
				if (this.activityTaskData_ == null)
				{
					this.ActivityTaskData = new ActivityTaskData();
				}
				this.ActivityTaskData.MergeFrom(other.ActivityTaskData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A682 RID: 108162 RVA: 0x003D93C4 File Offset: 0x003D75C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A683 RID: 108163 RVA: 0x003D93D0 File Offset: 0x003D75D0
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityTaskData_ == null)
					{
						this.ActivityTaskData = new ActivityTaskData();
					}
					input.ReadMessage(this.ActivityTaskData);
				}
			}
		}

		// Token: 0x04009AFE RID: 39678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AFF RID: 39679
		public const int ActivityTaskDataFieldNumber = 7;

		// Token: 0x04009B00 RID: 39680
		private ActivityTaskData activityTaskData_;
	}
}
