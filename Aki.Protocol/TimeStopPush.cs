using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001385 RID: 4997
	[NetMessage(EMessageId.TimeStopPush)]
	public sealed class TimeStopPush : IMessage<TimeStopPush>, IMessage, IEquatable<TimeStopPush>, IDeepCloneable<TimeStopPush>, IBufferMessage
	{
		// Token: 0x0601A865 RID: 108645 RVA: 0x003D96B4 File Offset: 0x003D78B4
		[NullableContext(1)]
		public static TimeStopPush Create()
		{
			return new TimeStopPush();
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x0601A866 RID: 108646 RVA: 0x003D96BB File Offset: 0x003D78BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x0601A867 RID: 108647 RVA: 0x003D96BE File Offset: 0x003D78BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeStopPush.Descriptor;
			}
		}

		// Token: 0x0601A868 RID: 108648 RVA: 0x003D96C5 File Offset: 0x003D78C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush()
		{
		}

		// Token: 0x0601A869 RID: 108649 RVA: 0x003D96CD File Offset: 0x003D78CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush(TimeStopPush other) : this()
		{
			this.timeDilation_ = other.timeDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A86A RID: 108650 RVA: 0x003D96F2 File Offset: 0x003D78F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush Clone()
		{
			return new TimeStopPush(this);
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x0601A86B RID: 108651 RVA: 0x003D96FA File Offset: 0x003D78FA
		// (set) Token: 0x0601A86C RID: 108652 RVA: 0x003D9702 File Offset: 0x003D7902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeDilation
		{
			get
			{
				return this.timeDilation_;
			}
			set
			{
				this.timeDilation_ = value;
			}
		}

		// Token: 0x0601A86D RID: 108653 RVA: 0x003D970B File Offset: 0x003D790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeStopPush);
		}

		// Token: 0x0601A86E RID: 108654 RVA: 0x003D9719 File Offset: 0x003D7919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeStopPush other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeDilation, other.TimeDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A86F RID: 108655 RVA: 0x003D9754 File Offset: 0x003D7954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimeDilation != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A870 RID: 108656 RVA: 0x003D979A File Offset: 0x003D799A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A871 RID: 108657 RVA: 0x003D97A7 File Offset: 0x003D79A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A872 RID: 108658 RVA: 0x003D97B0 File Offset: 0x003D79B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeDilation != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A873 RID: 108659 RVA: 0x003D97E8 File Offset: 0x003D79E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimeDilation != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A874 RID: 108660 RVA: 0x003D981F File Offset: 0x003D7A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeStopPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimeDilation != 0f)
			{
				this.TimeDilation = other.TimeDilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A875 RID: 108661 RVA: 0x003D9855 File Offset: 0x003D7A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A876 RID: 108662 RVA: 0x003D9860 File Offset: 0x003D7A60
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
				if (num != 125U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimeDilation = input.ReadFloat();
				}
			}
		}

		// Token: 0x04009A48 RID: 39496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A49 RID: 39497
		public const int TimeDilationFieldNumber = 15;

		// Token: 0x04009A4A RID: 39498
		private float timeDilation_;
	}
}
