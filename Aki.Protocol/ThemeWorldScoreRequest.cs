using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CF RID: 5071
	[NetMessage(EMessageId.ThemeWorldScoreRequest)]
	public sealed class ThemeWorldScoreRequest : IMessage<ThemeWorldScoreRequest>, IMessage, IEquatable<ThemeWorldScoreRequest>, IDeepCloneable<ThemeWorldScoreRequest>, IBufferMessage
	{
		// Token: 0x0601AFC8 RID: 110536 RVA: 0x003EE3D9 File Offset: 0x003EC5D9
		[NullableContext(1)]
		public static ThemeWorldScoreRequest Create()
		{
			return new ThemeWorldScoreRequest();
		}

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x0601AFC9 RID: 110537 RVA: 0x003EE3E0 File Offset: 0x003EC5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x0601AFCA RID: 110538 RVA: 0x003EE3E3 File Offset: 0x003EC5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeWorldScoreRequest.Descriptor;
			}
		}

		// Token: 0x0601AFCB RID: 110539 RVA: 0x003EE3EA File Offset: 0x003EC5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest()
		{
		}

		// Token: 0x0601AFCC RID: 110540 RVA: 0x003EE3FD File Offset: 0x003EC5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest(ThemeWorldScoreRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFCD RID: 110541 RVA: 0x003EE427 File Offset: 0x003EC627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest Clone()
		{
			return new ThemeWorldScoreRequest(this);
		}

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x0601AFCE RID: 110542 RVA: 0x003EE42F File Offset: 0x003EC62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AFCF RID: 110543 RVA: 0x003EE437 File Offset: 0x003EC637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeWorldScoreRequest);
		}

		// Token: 0x0601AFD0 RID: 110544 RVA: 0x003EE445 File Offset: 0x003EC645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeWorldScoreRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFD1 RID: 110545 RVA: 0x003EE478 File Offset: 0x003EC678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x003EE4AC File Offset: 0x003EC6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFD3 RID: 110547 RVA: 0x003EE4B9 File Offset: 0x003EC6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFD4 RID: 110548 RVA: 0x003EE4C2 File Offset: 0x003EC6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ThemeWorldScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFD5 RID: 110549 RVA: 0x003EE4EC File Offset: 0x003EC6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ThemeWorldScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFD6 RID: 110550 RVA: 0x003EE525 File Offset: 0x003EC725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeWorldScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFD7 RID: 110551 RVA: 0x003EE553 File Offset: 0x003EC753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFD8 RID: 110552 RVA: 0x003EE55C File Offset: 0x003EC75C
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, ThemeWorldScoreRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009DC3 RID: 40387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DC4 RID: 40388
		public const int IdsFieldNumber = 7;

		// Token: 0x04009DC5 RID: 40389
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04009DC6 RID: 40390
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
