using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F8 RID: 5112
	[NetMessage(EMessageId.TimeStopPush)]
	public sealed class TimeStopPush : IMessage<TimeStopPush>, IMessage, IEquatable<TimeStopPush>, IDeepCloneable<TimeStopPush>, IBufferMessage
	{
		// Token: 0x0601B2EE RID: 111342 RVA: 0x003F48C8 File Offset: 0x003F2AC8
		[NullableContext(1)]
		public static TimeStopPush Create()
		{
			return new TimeStopPush();
		}

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x0601B2EF RID: 111343 RVA: 0x003F48CF File Offset: 0x003F2ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x0601B2F0 RID: 111344 RVA: 0x003F48D2 File Offset: 0x003F2AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeStopPush.Descriptor;
			}
		}

		// Token: 0x0601B2F1 RID: 111345 RVA: 0x003F48D9 File Offset: 0x003F2AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush()
		{
		}

		// Token: 0x0601B2F2 RID: 111346 RVA: 0x003F48E1 File Offset: 0x003F2AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush(TimeStopPush other) : this()
		{
			this.timeDilation_ = other.timeDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2F3 RID: 111347 RVA: 0x003F4906 File Offset: 0x003F2B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeStopPush Clone()
		{
			return new TimeStopPush(this);
		}

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x0601B2F4 RID: 111348 RVA: 0x003F490E File Offset: 0x003F2B0E
		// (set) Token: 0x0601B2F5 RID: 111349 RVA: 0x003F4916 File Offset: 0x003F2B16
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

		// Token: 0x0601B2F6 RID: 111350 RVA: 0x003F491F File Offset: 0x003F2B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeStopPush);
		}

		// Token: 0x0601B2F7 RID: 111351 RVA: 0x003F492D File Offset: 0x003F2B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeStopPush other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeDilation, other.TimeDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2F8 RID: 111352 RVA: 0x003F4968 File Offset: 0x003F2B68
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

		// Token: 0x0601B2F9 RID: 111353 RVA: 0x003F49AE File Offset: 0x003F2BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2FA RID: 111354 RVA: 0x003F49BB File Offset: 0x003F2BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2FB RID: 111355 RVA: 0x003F49C4 File Offset: 0x003F2BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeDilation != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2FC RID: 111356 RVA: 0x003F49FC File Offset: 0x003F2BFC
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

		// Token: 0x0601B2FD RID: 111357 RVA: 0x003F4A33 File Offset: 0x003F2C33
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

		// Token: 0x0601B2FE RID: 111358 RVA: 0x003F4A69 File Offset: 0x003F2C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2FF RID: 111359 RVA: 0x003F4A74 File Offset: 0x003F2C74
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
				if (num != 93U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimeDilation = input.ReadFloat();
				}
			}
		}

		// Token: 0x04009E8D RID: 40589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E8E RID: 40590
		public const int TimeDilationFieldNumber = 11;

		// Token: 0x04009E8F RID: 40591
		private float timeDilation_;
	}
}
