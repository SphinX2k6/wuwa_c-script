using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A4 RID: 164
	[NetMessage(EMessageId.AddEntityAoiNotify)]
	public sealed class AddEntityAoiNotify : IMessage<AddEntityAoiNotify>, IMessage, IEquatable<AddEntityAoiNotify>, IDeepCloneable<AddEntityAoiNotify>, IBufferMessage
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x0004FCDD File Offset: 0x0004DEDD
		[NullableContext(1)]
		public static AddEntityAoiNotify Create()
		{
			return new AddEntityAoiNotify();
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0004FCE7 File Offset: 0x0004DEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddEntityAoiNotify.Descriptor;
			}
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0004FCEE File Offset: 0x0004DEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify()
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0004FD01 File Offset: 0x0004DF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify(AddEntityAoiNotify other) : this()
		{
			this.entityInfos_ = other.entityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0004FD2B File Offset: 0x0004DF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify Clone()
		{
			return new AddEntityAoiNotify(this);
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0004FD33 File Offset: 0x0004DF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> EntityInfos
		{
			get
			{
				return this.entityInfos_;
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0004FD3B File Offset: 0x0004DF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddEntityAoiNotify);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0004FD49 File Offset: 0x0004DF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddEntityAoiNotify other)
		{
			return other != null && (other == this || (this.entityInfos_.Equals(other.entityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0004FDB0 File Offset: 0x0004DFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0004FDBD File Offset: 0x0004DFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0004FDC6 File Offset: 0x0004DFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityInfos_.WriteTo(ref output, AddEntityAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0004FDF0 File Offset: 0x0004DFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityInfos_.CalculateSize(AddEntityAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0004FE29 File Offset: 0x0004E029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddEntityAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityInfos_.Add(other.entityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0004FE57 File Offset: 0x0004E057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0004FE60 File Offset: 0x0004E060
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityInfos_.AddEntriesFrom(ref input, AddEntityAoiNotify._repeated_entityInfos_codec);
				}
			}
		}

		// Token: 0x04002344 RID: 9028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002345 RID: 9029
		public const int EntityInfosFieldNumber = 4;

		// Token: 0x04002346 RID: 9030
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_entityInfos_codec = FieldCodec.ForMessage<DynamicEntityInformation>(34U, DynamicEntityInformation.Parser);

		// Token: 0x04002347 RID: 9031
		private readonly RepeatedField<DynamicEntityInformation> entityInfos_ = new RepeatedField<DynamicEntityInformation>();
	}
}
