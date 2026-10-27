using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F9 RID: 1273
	[NetMessage(EMessageId.ExploreProgressResponse)]
	public sealed class ExploreProgressResponse : IMessage<ExploreProgressResponse>, IMessage, IEquatable<ExploreProgressResponse>, IDeepCloneable<ExploreProgressResponse>, IBufferMessage
	{
		// Token: 0x06007828 RID: 30760 RVA: 0x00124BFD File Offset: 0x00122DFD
		[NullableContext(1)]
		public static ExploreProgressResponse Create()
		{
			return new ExploreProgressResponse();
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007829 RID: 30761 RVA: 0x00124C04 File Offset: 0x00122E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x00124C07 File Offset: 0x00122E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressResponse.Descriptor;
			}
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00124C0E File Offset: 0x00122E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse()
		{
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00124C21 File Offset: 0x00122E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse(ExploreProgressResponse other) : this()
		{
			this.areaProgress_ = other.areaProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00124C4B File Offset: 0x00122E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressResponse Clone()
		{
			return new ExploreProgressResponse(this);
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x00124C53 File Offset: 0x00122E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaExploreInfo> AreaProgress
		{
			get
			{
				return this.areaProgress_;
			}
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00124C5B File Offset: 0x00122E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressResponse);
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00124C69 File Offset: 0x00122E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressResponse other)
		{
			return other != null && (other == this || (this.areaProgress_.Equals(other.areaProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00124C9C File Offset: 0x00122E9C
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

		// Token: 0x06007832 RID: 30770 RVA: 0x00124CD0 File Offset: 0x00122ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00124CDD File Offset: 0x00122EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00124CE6 File Offset: 0x00122EE6
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

		// Token: 0x06007835 RID: 30773 RVA: 0x00124D10 File Offset: 0x00122F10
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

		// Token: 0x06007836 RID: 30774 RVA: 0x00124D49 File Offset: 0x00122F49
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

		// Token: 0x06007837 RID: 30775 RVA: 0x00124D77 File Offset: 0x00122F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00124D80 File Offset: 0x00122F80
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.areaProgress_.AddEntriesFrom(ref input, ExploreProgressResponse._repeated_areaProgress_codec);
				}
			}
		}

		// Token: 0x04003E58 RID: 15960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E59 RID: 15961
		public const int AreaProgressFieldNumber = 10;

		// Token: 0x04003E5A RID: 15962
		private static readonly FieldCodec<AreaExploreInfo> _repeated_areaProgress_codec = FieldCodec.ForMessage<AreaExploreInfo>(82U, AreaExploreInfo.Parser);

		// Token: 0x04003E5B RID: 15963
		private readonly RepeatedField<AreaExploreInfo> areaProgress_ = new RepeatedField<AreaExploreInfo>();
	}
}
