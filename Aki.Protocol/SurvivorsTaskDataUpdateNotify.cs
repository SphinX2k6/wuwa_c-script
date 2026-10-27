using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012ED RID: 4845
	[NetMessage(EMessageId.SurvivorsTaskDataUpdateNotify)]
	public sealed class SurvivorsTaskDataUpdateNotify : IMessage<SurvivorsTaskDataUpdateNotify>, IMessage, IEquatable<SurvivorsTaskDataUpdateNotify>, IDeepCloneable<SurvivorsTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019C3C RID: 105532 RVA: 0x003BEAE1 File Offset: 0x003BCCE1
		[NullableContext(1)]
		public static SurvivorsTaskDataUpdateNotify Create()
		{
			return new SurvivorsTaskDataUpdateNotify();
		}

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x06019C3D RID: 105533 RVA: 0x003BEAE8 File Offset: 0x003BCCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x06019C3E RID: 105534 RVA: 0x003BEAEB File Offset: 0x003BCCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019C3F RID: 105535 RVA: 0x003BEAF2 File Offset: 0x003BCCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify()
		{
		}

		// Token: 0x06019C40 RID: 105536 RVA: 0x003BEAFA File Offset: 0x003BCCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify(SurvivorsTaskDataUpdateNotify other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C41 RID: 105537 RVA: 0x003BEB2F File Offset: 0x003BCD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTaskDataUpdateNotify Clone()
		{
			return new SurvivorsTaskDataUpdateNotify(this);
		}

		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x06019C42 RID: 105538 RVA: 0x003BEB37 File Offset: 0x003BCD37
		// (set) Token: 0x06019C43 RID: 105539 RVA: 0x003BEB3F File Offset: 0x003BCD3F
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

		// Token: 0x06019C44 RID: 105540 RVA: 0x003BEB48 File Offset: 0x003BCD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTaskDataUpdateNotify);
		}

		// Token: 0x06019C45 RID: 105541 RVA: 0x003BEB56 File Offset: 0x003BCD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C46 RID: 105542 RVA: 0x003BEB8C File Offset: 0x003BCD8C
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

		// Token: 0x06019C47 RID: 105543 RVA: 0x003BEBC8 File Offset: 0x003BCDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C48 RID: 105544 RVA: 0x003BEBD5 File Offset: 0x003BCDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C49 RID: 105545 RVA: 0x003BEBDE File Offset: 0x003BCDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C4A RID: 105546 RVA: 0x003BEC10 File Offset: 0x003BCE10
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

		// Token: 0x06019C4B RID: 105547 RVA: 0x003BEC50 File Offset: 0x003BCE50
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

		// Token: 0x06019C4C RID: 105548 RVA: 0x003BECA4 File Offset: 0x003BCEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C4D RID: 105549 RVA: 0x003BECB0 File Offset: 0x003BCEB0
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
				if (num != 18U)
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

		// Token: 0x040096D4 RID: 38612
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096D5 RID: 38613
		public const int ActivityTaskDataFieldNumber = 2;

		// Token: 0x040096D6 RID: 38614
		private ActivityTaskData activityTaskData_;
	}
}
