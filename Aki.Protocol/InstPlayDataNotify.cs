using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000814 RID: 2068
	[NetMessage(EMessageId.InstPlayDataNotify)]
	public sealed class InstPlayDataNotify : IMessage<InstPlayDataNotify>, IMessage, IEquatable<InstPlayDataNotify>, IDeepCloneable<InstPlayDataNotify>, IBufferMessage
	{
		// Token: 0x0600B941 RID: 47425 RVA: 0x001B9AD9 File Offset: 0x001B7CD9
		[NullableContext(1)]
		public static InstPlayDataNotify Create()
		{
			return new InstPlayDataNotify();
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x001B9AE0 File Offset: 0x001B7CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x0600B943 RID: 47427 RVA: 0x001B9AE3 File Offset: 0x001B7CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstPlayDataNotify.Descriptor;
			}
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x001B9AEA File Offset: 0x001B7CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify()
		{
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x001B9AF2 File Offset: 0x001B7CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify(InstPlayDataNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x001B9B17 File Offset: 0x001B7D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify Clone()
		{
			return new InstPlayDataNotify(this);
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x0600B947 RID: 47431 RVA: 0x001B9B1F File Offset: 0x001B7D1F
		// (set) Token: 0x0600B948 RID: 47432 RVA: 0x001B9B27 File Offset: 0x001B7D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x001B9B30 File Offset: 0x001B7D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstPlayDataNotify);
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x001B9B3E File Offset: 0x001B7D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstPlayDataNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x001B9B6C File Offset: 0x001B7D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x001B9BAB File Offset: 0x001B7DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x001B9BB8 File Offset: 0x001B7DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x001B9BC1 File Offset: 0x001B7DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x001B9BF4 File Offset: 0x001B7DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x001B9C32 File Offset: 0x001B7E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstPlayDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x001B9C63 File Offset: 0x001B7E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x001B9C6C File Offset: 0x001B7E6C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040051EA RID: 20970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051EB RID: 20971
		public const int IdFieldNumber = 14;

		// Token: 0x040051EC RID: 20972
		private int id_;
	}
}
