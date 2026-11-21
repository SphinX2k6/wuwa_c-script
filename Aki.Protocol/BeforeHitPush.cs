using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000197 RID: 407
	[NetMessage(EMessageId.BeforeHitPush)]
	public sealed class BeforeHitPush : IMessage<BeforeHitPush>, IMessage, IEquatable<BeforeHitPush>, IDeepCloneable<BeforeHitPush>, IBufferMessage
	{
		// Token: 0x0600308A RID: 12426 RVA: 0x0007C2A4 File Offset: 0x0007A4A4
		[NullableContext(1)]
		public static BeforeHitPush Create()
		{
			return new BeforeHitPush();
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x0007C2AB File Offset: 0x0007A4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x0007C2AE File Offset: 0x0007A4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeforeHitPush.Descriptor;
			}
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x0007C2B5 File Offset: 0x0007A4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush()
		{
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x0007C2BD File Offset: 0x0007A4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush(BeforeHitPush other) : this()
		{
			this.beforeHitInformation_ = ((other.beforeHitInformation_ != null) ? other.beforeHitInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x0007C2F2 File Offset: 0x0007A4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush Clone()
		{
			return new BeforeHitPush(this);
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x0007C2FA File Offset: 0x0007A4FA
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x0007C302 File Offset: 0x0007A502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation BeforeHitInformation
		{
			get
			{
				return this.beforeHitInformation_;
			}
			set
			{
				this.beforeHitInformation_ = value;
			}
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0007C30B File Offset: 0x0007A50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeforeHitPush);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0007C319 File Offset: 0x0007A519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeforeHitPush other)
		{
			return other != null && (other == this || (object.Equals(this.BeforeHitInformation, other.BeforeHitInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x0007C34C File Offset: 0x0007A54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.beforeHitInformation_ != null)
			{
				num ^= this.BeforeHitInformation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x0007C388 File Offset: 0x0007A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x0007C395 File Offset: 0x0007A595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0007C39E File Offset: 0x0007A59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.beforeHitInformation_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BeforeHitInformation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.beforeHitInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BeforeHitInformation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0007C410 File Offset: 0x0007A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeforeHitPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.beforeHitInformation_ != null)
			{
				if (this.beforeHitInformation_ == null)
				{
					this.BeforeHitInformation = new BeforeHitInformation();
				}
				this.BeforeHitInformation.MergeFrom(other.BeforeHitInformation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0007C464 File Offset: 0x0007A664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x0007C470 File Offset: 0x0007A670
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
					if (this.beforeHitInformation_ == null)
					{
						this.BeforeHitInformation = new BeforeHitInformation();
					}
					input.ReadMessage(this.BeforeHitInformation);
				}
			}
		}

		// Token: 0x04002950 RID: 10576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002951 RID: 10577
		public const int BeforeHitInformationFieldNumber = 12;

		// Token: 0x04002952 RID: 10578
		private BeforeHitInformation beforeHitInformation_;
	}
}
