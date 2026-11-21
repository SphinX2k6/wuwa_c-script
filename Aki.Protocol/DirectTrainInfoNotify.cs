using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C2 RID: 962
	[NetMessage(EMessageId.DirectTrainInfoNotify)]
	public sealed class DirectTrainInfoNotify : IMessage<DirectTrainInfoNotify>, IMessage, IEquatable<DirectTrainInfoNotify>, IDeepCloneable<DirectTrainInfoNotify>, IBufferMessage
	{
		// Token: 0x06005E69 RID: 24169 RVA: 0x000E534D File Offset: 0x000E354D
		[NullableContext(1)]
		public static DirectTrainInfoNotify Create()
		{
			return new DirectTrainInfoNotify();
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x000E5354 File Offset: 0x000E3554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x000E5357 File Offset: 0x000E3557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoNotify.Descriptor;
			}
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x000E535E File Offset: 0x000E355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify()
		{
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x000E5366 File Offset: 0x000E3566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify(DirectTrainInfoNotify other) : this()
		{
			this.activity_ = ((other.activity_ != null) ? other.activity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x000E539B File Offset: 0x000E359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify Clone()
		{
			return new DirectTrainInfoNotify(this);
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x000E53A3 File Offset: 0x000E35A3
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x000E53AB File Offset: 0x000E35AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData Activity
		{
			get
			{
				return this.activity_;
			}
			set
			{
				this.activity_ = value;
			}
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x000E53B4 File Offset: 0x000E35B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoNotify);
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x000E53C2 File Offset: 0x000E35C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Activity, other.Activity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x000E53F8 File Offset: 0x000E35F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activity_ != null)
			{
				num ^= this.Activity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x000E5434 File Offset: 0x000E3634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x000E5441 File Offset: 0x000E3641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x000E544A File Offset: 0x000E364A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activity_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Activity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x000E547C File Offset: 0x000E367C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Activity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x000E54BC File Offset: 0x000E36BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activity_ != null)
			{
				if (this.activity_ == null)
				{
					this.Activity = new ActivityData();
				}
				this.Activity.MergeFrom(other.Activity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x000E5510 File Offset: 0x000E3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x000E551C File Offset: 0x000E371C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activity_ == null)
					{
						this.Activity = new ActivityData();
					}
					input.ReadMessage(this.Activity);
				}
			}
		}

		// Token: 0x04003736 RID: 14134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003737 RID: 14135
		public const int ActivityFieldNumber = 12;

		// Token: 0x04003738 RID: 14136
		private ActivityData activity_;
	}
}
