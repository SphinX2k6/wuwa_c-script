using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A29 RID: 2601
	[NetMessage(EMessageId.MotorDataNotify)]
	public sealed class MotorDataNotify : IMessage<MotorDataNotify>, IMessage, IEquatable<MotorDataNotify>, IDeepCloneable<MotorDataNotify>, IBufferMessage
	{
		// Token: 0x0600E350 RID: 58192 RVA: 0x0021448C File Offset: 0x0021268C
		[NullableContext(1)]
		public static MotorDataNotify Create()
		{
			return new MotorDataNotify();
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600E351 RID: 58193 RVA: 0x00214493 File Offset: 0x00212693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600E352 RID: 58194 RVA: 0x00214496 File Offset: 0x00212696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDataNotify.Descriptor;
			}
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x0021449D File Offset: 0x0021269D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify()
		{
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x002144A5 File Offset: 0x002126A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify(MotorDataNotify other) : this()
		{
			this.motor_ = ((other.motor_ != null) ? other.motor_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x002144DA File Offset: 0x002126DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDataNotify Clone()
		{
			return new MotorDataNotify(this);
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x002144E2 File Offset: 0x002126E2
		// (set) Token: 0x0600E357 RID: 58199 RVA: 0x002144EA File Offset: 0x002126EA
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

		// Token: 0x0600E358 RID: 58200 RVA: 0x002144F3 File Offset: 0x002126F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDataNotify);
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x00214501 File Offset: 0x00212701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Motor, other.Motor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x00214534 File Offset: 0x00212734
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

		// Token: 0x0600E35B RID: 58203 RVA: 0x00214570 File Offset: 0x00212770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E35C RID: 58204 RVA: 0x0021457D File Offset: 0x0021277D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x00214586 File Offset: 0x00212786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motor_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Motor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x002145B8 File Offset: 0x002127B8
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

		// Token: 0x0600E35F RID: 58207 RVA: 0x002145F8 File Offset: 0x002127F8
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

		// Token: 0x0600E360 RID: 58208 RVA: 0x0021464C File Offset: 0x0021284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x00214658 File Offset: 0x00212858
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
					if (this.motor_ == null)
					{
						this.Motor = new MotorPb();
					}
					input.ReadMessage(this.Motor);
				}
			}
		}

		// Token: 0x04005D2C RID: 23852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D2D RID: 23853
		public const int MotorFieldNumber = 1;

		// Token: 0x04005D2E RID: 23854
		private MotorPb motor_;
	}
}
