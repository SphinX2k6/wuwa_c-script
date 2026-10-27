using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFE RID: 3838
	[NetMessage(EMessageId.RemoveInstanceTimerNotify)]
	public sealed class RemoveInstanceTimerNotify : IMessage<RemoveInstanceTimerNotify>, IMessage, IEquatable<RemoveInstanceTimerNotify>, IDeepCloneable<RemoveInstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x060148FE RID: 84222 RVA: 0x002FCB70 File Offset: 0x002FAD70
		[NullableContext(1)]
		public static RemoveInstanceTimerNotify Create()
		{
			return new RemoveInstanceTimerNotify();
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x060148FF RID: 84223 RVA: 0x002FCB77 File Offset: 0x002FAD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x06014900 RID: 84224 RVA: 0x002FCB7A File Offset: 0x002FAD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x002FCB81 File Offset: 0x002FAD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify()
		{
		}

		// Token: 0x06014902 RID: 84226 RVA: 0x002FCB89 File Offset: 0x002FAD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify(RemoveInstanceTimerNotify other) : this()
		{
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014903 RID: 84227 RVA: 0x002FCBAE File Offset: 0x002FADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerNotify Clone()
		{
			return new RemoveInstanceTimerNotify(this);
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x06014904 RID: 84228 RVA: 0x002FCBB6 File Offset: 0x002FADB6
		// (set) Token: 0x06014905 RID: 84229 RVA: 0x002FCBBE File Offset: 0x002FADBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimerId
		{
			get
			{
				return this.timerId_;
			}
			set
			{
				this.timerId_ = value;
			}
		}

		// Token: 0x06014906 RID: 84230 RVA: 0x002FCBC7 File Offset: 0x002FADC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerNotify);
		}

		// Token: 0x06014907 RID: 84231 RVA: 0x002FCBD5 File Offset: 0x002FADD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerNotify other)
		{
			return other != null && (other == this || (this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014908 RID: 84232 RVA: 0x002FCC04 File Offset: 0x002FAE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimerId != 0)
			{
				num ^= this.TimerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014909 RID: 84233 RVA: 0x002FCC43 File Offset: 0x002FAE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601490A RID: 84234 RVA: 0x002FCC50 File Offset: 0x002FAE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601490B RID: 84235 RVA: 0x002FCC59 File Offset: 0x002FAE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601490C RID: 84236 RVA: 0x002FCC8C File Offset: 0x002FAE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601490D RID: 84237 RVA: 0x002FCCCA File Offset: 0x002FAECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveInstanceTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimerId != 0)
			{
				this.TimerId = other.TimerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601490E RID: 84238 RVA: 0x002FCCFB File Offset: 0x002FAEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601490F RID: 84239 RVA: 0x002FCD04 File Offset: 0x002FAF04
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C98 RID: 31896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C99 RID: 31897
		public const int TimerIdFieldNumber = 3;

		// Token: 0x04007C9A RID: 31898
		private int timerId_;
	}
}
