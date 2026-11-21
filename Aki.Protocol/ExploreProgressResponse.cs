using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E3 RID: 1251
	[NetMessage(EMessageId.ExploreProgressResponse)]
	public sealed class ExploreProgressResponse : IMessage<ExploreProgressResponse>, IMessage, IEquatable<ExploreProgressResponse>, IDeepCloneable<ExploreProgressResponse>, IBufferMessage
	{
		// Token: 0x060076AC RID: 30380 RVA: 0x00121D69 File Offset: 0x0011FF69
		[NullableContext(1)]
		public static ExploreProgressResponse Create()
		{
			return new ExploreProgressResponse();
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x060076AD RID: 30381 RVA: 0x00121D70 File Offset: 0x0011FF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x00121D73 File Offset: 0x0011FF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressResponse.Descriptor;
			}
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00121D7A File Offset: 0x0011FF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse()
		{
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00121D8D File Offset: 0x0011FF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse(ExploreProgressResponse other) : this()
		{
			this.areaProgress_ = other.areaProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00121DB7 File Offset: 0x0011FFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse Clone()
		{
			return new ExploreProgressResponse(this);
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00121DBF File Offset: 0x0011FFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaExploreInfo> AreaProgress
		{
			get
			{
				return this.areaProgress_;
			}
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00121DC7 File Offset: 0x0011FFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressResponse);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00121DD5 File Offset: 0x0011FFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressResponse other)
		{
			return other != null && (other == this || (this.areaProgress_.Equals(other.areaProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00121E08 File Offset: 0x00120008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.areaProgress_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00121E3C File Offset: 0x0012003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00121E49 File Offset: 0x00120049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00121E52 File Offset: 0x00120052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaProgress_.WriteTo(ref output, ExploreProgressResponse._repeated_areaProgress_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00121E7C File Offset: 0x0012007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.areaProgress_.CalculateSize(ExploreProgressResponse._repeated_areaProgress_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00121EB5 File Offset: 0x001200B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.areaProgress_.Add(other.areaProgress_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00121EE3 File Offset: 0x001200E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00121EEC File Offset: 0x001200EC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.areaProgress_.AddEntriesFrom(ref input, ExploreProgressResponse._repeated_areaProgress_codec);
				}
			}
		}

		// Token: 0x04003E49 RID: 15945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E4A RID: 15946
		public const int AreaProgressFieldNumber = 14;

		// Token: 0x04003E4B RID: 15947
		private static readonly FieldCodec<AreaExploreInfo> _repeated_areaProgress_codec = FieldCodec.ForMessage<AreaExploreInfo>(114U, AreaExploreInfo.Parser);

		// Token: 0x04003E4C RID: 15948
		private readonly RepeatedField<AreaExploreInfo> areaProgress_ = new RepeatedField<AreaExploreInfo>();
	}
}
