using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A18 RID: 2584
	[NetMessage(EMessageId.MotorDataNotify)]
	public sealed class MotorDataNotify : IMessage<MotorDataNotify>, IMessage, IEquatable<MotorDataNotify>, IDeepCloneable<MotorDataNotify>, IBufferMessage
	{
		// Token: 0x0600E236 RID: 57910 RVA: 0x00212298 File Offset: 0x00210498
		[NullableContext(1)]
		public static MotorDataNotify Create()
		{
			return new MotorDataNotify();
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600E237 RID: 57911 RVA: 0x0021229F File Offset: 0x0021049F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x002122A2 File Offset: 0x002104A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDataNotify.Descriptor;
			}
		}

		// Token: 0x0600E239 RID: 57913 RVA: 0x002122A9 File Offset: 0x002104A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify()
		{
		}

		// Token: 0x0600E23A RID: 57914 RVA: 0x002122B1 File Offset: 0x002104B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify(MotorDataNotify other) : this()
		{
			this.motor_ = ((other.motor_ != null) ? other.motor_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E23B RID: 57915 RVA: 0x002122E6 File Offset: 0x002104E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify Clone()
		{
			return new MotorDataNotify(this);
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600E23C RID: 57916 RVA: 0x002122EE File Offset: 0x002104EE
		// (set) Token: 0x0600E23D RID: 57917 RVA: 0x002122F6 File Offset: 0x002104F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb Motor
		{
			get
			{
				return this.motor_;
			}
			set
			{
				this.motor_ = value;
			}
		}

		// Token: 0x0600E23E RID: 57918 RVA: 0x002122FF File Offset: 0x002104FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDataNotify);
		}

		// Token: 0x0600E23F RID: 57919 RVA: 0x0021230D File Offset: 0x0021050D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Motor, other.Motor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E240 RID: 57920 RVA: 0x00212340 File Offset: 0x00210540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motor_ != null)
			{
				num ^= this.Motor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E241 RID: 57921 RVA: 0x0021237C File Offset: 0x0021057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E242 RID: 57922 RVA: 0x00212389 File Offset: 0x00210589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E243 RID: 57923 RVA: 0x00212392 File Offset: 0x00210592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motor_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Motor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E244 RID: 57924 RVA: 0x002123C4 File Offset: 0x002105C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motor_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E245 RID: 57925 RVA: 0x00212404 File Offset: 0x00210604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motor_ != null)
			{
				if (this.motor_ == null)
				{
					this.Motor = new MotorPb();
				}
				this.Motor.MergeFrom(other.Motor);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E246 RID: 57926 RVA: 0x00212458 File Offset: 0x00210658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E247 RID: 57927 RVA: 0x00212464 File Offset: 0x00210664
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
					if (this.motor_ == null)
					{
						this.Motor = new MotorPb();
					}
					input.ReadMessage(this.Motor);
				}
			}
		}

		// Token: 0x04005D35 RID: 23861
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D36 RID: 23862
		public const int MotorFieldNumber = 7;

		// Token: 0x04005D37 RID: 23863
		private MotorPb motor_;
	}
}
