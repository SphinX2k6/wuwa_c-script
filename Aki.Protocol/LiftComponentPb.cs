using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000909 RID: 2313
	public sealed class LiftComponentPb : IMessage<LiftComponentPb>, IMessage, IEquatable<LiftComponentPb>, IDeepCloneable<LiftComponentPb>, IBufferMessage
	{
		// Token: 0x0600CC7C RID: 52348 RVA: 0x001E26D5 File Offset: 0x001E08D5
		[NullableContext(1)]
		public static LiftComponentPb Create()
		{
			return new LiftComponentPb();
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600CC7D RID: 52349 RVA: 0x001E26DC File Offset: 0x001E08DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x001E26DF File Offset: 0x001E08DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftComponentPb.Descriptor;
			}
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x001E26E6 File Offset: 0x001E08E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb()
		{
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x001E26EE File Offset: 0x001E08EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb(LiftComponentPb other) : this()
		{
			this.location_ = other.location_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x001E2713 File Offset: 0x001E0913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb Clone()
		{
			return new LiftComponentPb(this);
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600CC82 RID: 52354 RVA: 0x001E271B File Offset: 0x001E091B
		// (set) Token: 0x0600CC83 RID: 52355 RVA: 0x001E2723 File Offset: 0x001E0923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x001E272C File Offset: 0x001E092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftComponentPb);
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x001E273A File Offset: 0x001E093A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftComponentPb other)
		{
			return other != null && (other == this || (this.Location == other.Location && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x001E2768 File Offset: 0x001E0968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Location != 0)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x001E27A7 File Offset: 0x001E09A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x001E27B4 File Offset: 0x001E09B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x001E27BD File Offset: 0x001E09BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Location != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x001E27F0 File Offset: 0x001E09F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Location != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x001E282E File Offset: 0x001E0A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Location != 0)
			{
				this.Location = other.Location;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x001E285F File Offset: 0x001E0A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x001E2868 File Offset: 0x001E0A68
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Location = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005706 RID: 22278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005707 RID: 22279
		public const int LocationFieldNumber = 1;

		// Token: 0x04005708 RID: 22280
		private int location_;
	}
}
