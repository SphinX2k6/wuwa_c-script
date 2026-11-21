using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033C RID: 828
	[NetMessage(EMessageId.DangoBrawlBagOperateRequest)]
	public sealed class DangoBrawlBagOperateRequest : IMessage<DangoBrawlBagOperateRequest>, IMessage, IEquatable<DangoBrawlBagOperateRequest>, IDeepCloneable<DangoBrawlBagOperateRequest>, IBufferMessage
	{
		// Token: 0x06005354 RID: 21332 RVA: 0x000CBAAE File Offset: 0x000C9CAE
		[NullableContext(1)]
		public static DangoBrawlBagOperateRequest Create()
		{
			return new DangoBrawlBagOperateRequest();
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x000CBAB5 File Offset: 0x000C9CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x000CBAB8 File Offset: 0x000C9CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOperateRequest.Descriptor;
			}
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x000CBABF File Offset: 0x000C9CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest()
		{
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x000CBAD2 File Offset: 0x000C9CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest(DangoBrawlBagOperateRequest other) : this()
		{
			this.ops_ = other.ops_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x000CBAFC File Offset: 0x000C9CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest Clone()
		{
			return new DangoBrawlBagOperateRequest(this);
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x000CBB04 File Offset: 0x000C9D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlBagOpInfo> Ops
		{
			get
			{
				return this.ops_;
			}
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x000CBB0C File Offset: 0x000C9D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOperateRequest);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x000CBB1A File Offset: 0x000C9D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOperateRequest other)
		{
			return other != null && (other == this || (this.ops_.Equals(other.ops_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x000CBB50 File Offset: 0x000C9D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ops_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x000CBB84 File Offset: 0x000C9D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x000CBB91 File Offset: 0x000C9D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x000CBB9A File Offset: 0x000C9D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ops_.WriteTo(ref output, DangoBrawlBagOperateRequest._repeated_ops_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x000CBBC4 File Offset: 0x000C9DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ops_.CalculateSize(DangoBrawlBagOperateRequest._repeated_ops_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x000CBBFD File Offset: 0x000C9DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ops_.Add(other.ops_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x000CBC2B File Offset: 0x000C9E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x000CBC34 File Offset: 0x000C9E34
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ops_.AddEntriesFrom(ref input, DangoBrawlBagOperateRequest._repeated_ops_codec);
				}
			}
		}

		// Token: 0x040033CF RID: 13263
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D0 RID: 13264
		public const int OpsFieldNumber = 2;

		// Token: 0x040033D1 RID: 13265
		private static readonly FieldCodec<DangoBrawlBagOpInfo> _repeated_ops_codec = FieldCodec.ForMessage<DangoBrawlBagOpInfo>(18U, DangoBrawlBagOpInfo.Parser);

		// Token: 0x040033D2 RID: 13266
		private readonly RepeatedField<DangoBrawlBagOpInfo> ops_ = new RepeatedField<DangoBrawlBagOpInfo>();
	}
}
