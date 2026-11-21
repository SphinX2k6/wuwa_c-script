using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8D RID: 2957
	[NetMessage(EMessageId.OnlineMotorStartNotify)]
	public sealed class OnlineMotorStartNotify : IMessage<OnlineMotorStartNotify>, IMessage, IEquatable<OnlineMotorStartNotify>, IDeepCloneable<OnlineMotorStartNotify>, IBufferMessage
	{
		// Token: 0x060100F1 RID: 65777 RVA: 0x00258A3C File Offset: 0x00256C3C
		[NullableContext(1)]
		public static OnlineMotorStartNotify Create()
		{
			return new OnlineMotorStartNotify();
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x060100F2 RID: 65778 RVA: 0x00258A43 File Offset: 0x00256C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x060100F3 RID: 65779 RVA: 0x00258A46 File Offset: 0x00256C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorStartNotify.Descriptor;
			}
		}

		// Token: 0x060100F4 RID: 65780 RVA: 0x00258A4D File Offset: 0x00256C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify()
		{
		}

		// Token: 0x060100F5 RID: 65781 RVA: 0x00258A55 File Offset: 0x00256C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify(OnlineMotorStartNotify other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100F6 RID: 65782 RVA: 0x00258A7A File Offset: 0x00256C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify Clone()
		{
			return new OnlineMotorStartNotify(this);
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x060100F7 RID: 65783 RVA: 0x00258A82 File Offset: 0x00256C82
		// (set) Token: 0x060100F8 RID: 65784 RVA: 0x00258A8A File Offset: 0x00256C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x060100F9 RID: 65785 RVA: 0x00258A93 File Offset: 0x00256C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorStartNotify);
		}

		// Token: 0x060100FA RID: 65786 RVA: 0x00258AA1 File Offset: 0x00256CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorStartNotify other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100FB RID: 65787 RVA: 0x00258AD0 File Offset: 0x00256CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100FC RID: 65788 RVA: 0x00258B0F File Offset: 0x00256D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100FD RID: 65789 RVA: 0x00258B1C File Offset: 0x00256D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100FE RID: 65790 RVA: 0x00258B25 File Offset: 0x00256D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100FF RID: 65791 RVA: 0x00258B58 File Offset: 0x00256D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010100 RID: 65792 RVA: 0x00258B96 File Offset: 0x00256D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010101 RID: 65793 RVA: 0x00258BC7 File Offset: 0x00256DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010102 RID: 65794 RVA: 0x00258BD0 File Offset: 0x00256DD0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BeginTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040066D5 RID: 26325
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066D6 RID: 26326
		public const int BeginTimeFieldNumber = 15;

		// Token: 0x040066D7 RID: 26327
		private long beginTime_;
	}
}
