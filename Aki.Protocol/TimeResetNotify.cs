using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F4 RID: 5108
	[NetMessage(EMessageId.TimeResetNotify)]
	public sealed class TimeResetNotify : IMessage<TimeResetNotify>, IMessage, IEquatable<TimeResetNotify>, IDeepCloneable<TimeResetNotify>, IBufferMessage
	{
		// Token: 0x0601B29C RID: 111260 RVA: 0x003F3E21 File Offset: 0x003F2021
		[NullableContext(1)]
		public static TimeResetNotify Create()
		{
			return new TimeResetNotify();
		}

		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x0601B29D RID: 111261 RVA: 0x003F3E28 File Offset: 0x003F2028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x0601B29E RID: 111262 RVA: 0x003F3E2B File Offset: 0x003F202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeResetNotify.Descriptor;
			}
		}

		// Token: 0x0601B29F RID: 111263 RVA: 0x003F3E32 File Offset: 0x003F2032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify()
		{
		}

		// Token: 0x0601B2A0 RID: 111264 RVA: 0x003F3E3A File Offset: 0x003F203A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify(TimeResetNotify other) : this()
		{
			this.resetId_ = other.resetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2A1 RID: 111265 RVA: 0x003F3E5F File Offset: 0x003F205F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify Clone()
		{
			return new TimeResetNotify(this);
		}

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x0601B2A2 RID: 111266 RVA: 0x003F3E67 File Offset: 0x003F2067
		// (set) Token: 0x0601B2A3 RID: 111267 RVA: 0x003F3E6F File Offset: 0x003F206F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetId
		{
			get
			{
				return this.resetId_;
			}
			set
			{
				this.resetId_ = value;
			}
		}

		// Token: 0x0601B2A4 RID: 111268 RVA: 0x003F3E78 File Offset: 0x003F2078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeResetNotify);
		}

		// Token: 0x0601B2A5 RID: 111269 RVA: 0x003F3E86 File Offset: 0x003F2086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeResetNotify other)
		{
			return other != null && (other == this || (this.ResetId == other.ResetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2A6 RID: 111270 RVA: 0x003F3EB4 File Offset: 0x003F20B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResetId != 0)
			{
				num ^= this.ResetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B2A7 RID: 111271 RVA: 0x003F3EF3 File Offset: 0x003F20F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2A8 RID: 111272 RVA: 0x003F3F00 File Offset: 0x003F2100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2A9 RID: 111273 RVA: 0x003F3F09 File Offset: 0x003F2109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ResetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2AA RID: 111274 RVA: 0x003F3F3C File Offset: 0x003F213C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B2AB RID: 111275 RVA: 0x003F3F7A File Offset: 0x003F217A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResetId != 0)
			{
				this.ResetId = other.ResetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B2AC RID: 111276 RVA: 0x003F3FAB File Offset: 0x003F21AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2AD RID: 111277 RVA: 0x003F3FB4 File Offset: 0x003F21B4
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
					this.ResetId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E76 RID: 40566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E77 RID: 40567
		public const int ResetIdFieldNumber = 15;

		// Token: 0x04009E78 RID: 40568
		private int resetId_;
	}
}
