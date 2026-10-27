using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015B RID: 347
	public sealed class BatchBulletCastComponentPb : IMessage<BatchBulletCastComponentPb>, IMessage, IEquatable<BatchBulletCastComponentPb>, IDeepCloneable<BatchBulletCastComponentPb>, IBufferMessage
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x0007232E File Offset: 0x0007052E
		[NullableContext(1)]
		public static BatchBulletCastComponentPb Create()
		{
			return new BatchBulletCastComponentPb();
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00072335 File Offset: 0x00070535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x00072338 File Offset: 0x00070538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchBulletCastComponentPb.Descriptor;
			}
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0007233F File Offset: 0x0007053F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb()
		{
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00072347 File Offset: 0x00070547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb(BatchBulletCastComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x0007236C File Offset: 0x0007056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb Clone()
		{
			return new BatchBulletCastComponentPb(this);
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x00072374 File Offset: 0x00070574
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x0007237C File Offset: 0x0007057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00072385 File Offset: 0x00070585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchBulletCastComponentPb);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00072393 File Offset: 0x00070593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchBulletCastComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000723C4 File Offset: 0x000705C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00072403 File Offset: 0x00070603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00072410 File Offset: 0x00070610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00072419 File Offset: 0x00070619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x0007244C File Offset: 0x0007064C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x0007248A File Offset: 0x0007068A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchBulletCastComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000724BB File Offset: 0x000706BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000724C4 File Offset: 0x000706C4
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
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040027C9 RID: 10185
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027CA RID: 10186
		public const int ContextIdFieldNumber = 1;

		// Token: 0x040027CB RID: 10187
		private long contextId_;
	}
}
