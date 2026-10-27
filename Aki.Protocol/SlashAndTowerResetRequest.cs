using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124E RID: 4686
	[NetMessage(EMessageId.SlashAndTowerResetRequest)]
	public sealed class SlashAndTowerResetRequest : IMessage<SlashAndTowerResetRequest>, IMessage, IEquatable<SlashAndTowerResetRequest>, IDeepCloneable<SlashAndTowerResetRequest>, IBufferMessage
	{
		// Token: 0x06018F7B RID: 102267 RVA: 0x003A1FE8 File Offset: 0x003A01E8
		[NullableContext(1)]
		public static SlashAndTowerResetRequest Create()
		{
			return new SlashAndTowerResetRequest();
		}

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x06018F7C RID: 102268 RVA: 0x003A1FEF File Offset: 0x003A01EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x06018F7D RID: 102269 RVA: 0x003A1FF2 File Offset: 0x003A01F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResetRequest.Descriptor;
			}
		}

		// Token: 0x06018F7E RID: 102270 RVA: 0x003A1FF9 File Offset: 0x003A01F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest()
		{
		}

		// Token: 0x06018F7F RID: 102271 RVA: 0x003A2001 File Offset: 0x003A0201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest(SlashAndTowerResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F80 RID: 102272 RVA: 0x003A2026 File Offset: 0x003A0226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest Clone()
		{
			return new SlashAndTowerResetRequest(this);
		}

		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x06018F81 RID: 102273 RVA: 0x003A202E File Offset: 0x003A022E
		// (set) Token: 0x06018F82 RID: 102274 RVA: 0x003A2036 File Offset: 0x003A0236
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

		// Token: 0x06018F83 RID: 102275 RVA: 0x003A203F File Offset: 0x003A023F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResetRequest);
		}

		// Token: 0x06018F84 RID: 102276 RVA: 0x003A204D File Offset: 0x003A024D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F85 RID: 102277 RVA: 0x003A207C File Offset: 0x003A027C
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

		// Token: 0x06018F86 RID: 102278 RVA: 0x003A20BB File Offset: 0x003A02BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F87 RID: 102279 RVA: 0x003A20C8 File Offset: 0x003A02C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F88 RID: 102280 RVA: 0x003A20D1 File Offset: 0x003A02D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F89 RID: 102281 RVA: 0x003A2104 File Offset: 0x003A0304
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

		// Token: 0x06018F8A RID: 102282 RVA: 0x003A2142 File Offset: 0x003A0342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResetRequest other)
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

		// Token: 0x06018F8B RID: 102283 RVA: 0x003A2173 File Offset: 0x003A0373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F8C RID: 102284 RVA: 0x003A217C File Offset: 0x003A037C
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400932E RID: 37678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400932F RID: 37679
		public const int IdFieldNumber = 15;

		// Token: 0x04009330 RID: 37680
		private int id_;
	}
}
