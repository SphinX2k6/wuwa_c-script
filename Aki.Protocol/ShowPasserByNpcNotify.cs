using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001212 RID: 4626
	[NetMessage(EMessageId.ShowPasserByNpcNotify)]
	public sealed class ShowPasserByNpcNotify : IMessage<ShowPasserByNpcNotify>, IMessage, IEquatable<ShowPasserByNpcNotify>, IDeepCloneable<ShowPasserByNpcNotify>, IBufferMessage
	{
		// Token: 0x06018A71 RID: 100977 RVA: 0x00395A36 File Offset: 0x00393C36
		[NullableContext(1)]
		public static ShowPasserByNpcNotify Create()
		{
			return new ShowPasserByNpcNotify();
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x06018A72 RID: 100978 RVA: 0x00395A3D File Offset: 0x00393C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x06018A73 RID: 100979 RVA: 0x00395A40 File Offset: 0x00393C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowPasserByNpcNotify.Descriptor;
			}
		}

		// Token: 0x06018A74 RID: 100980 RVA: 0x00395A47 File Offset: 0x00393C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify()
		{
		}

		// Token: 0x06018A75 RID: 100981 RVA: 0x00395A5A File Offset: 0x00393C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify(ShowPasserByNpcNotify other) : this()
		{
			this.isHide_ = other.isHide_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A76 RID: 100982 RVA: 0x00395A90 File Offset: 0x00393C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify Clone()
		{
			return new ShowPasserByNpcNotify(this);
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x06018A77 RID: 100983 RVA: 0x00395A98 File Offset: 0x00393C98
		// (set) Token: 0x06018A78 RID: 100984 RVA: 0x00395AA0 File Offset: 0x00393CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHide
		{
			get
			{
				return this.isHide_;
			}
			set
			{
				this.isHide_ = value;
			}
		}

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x06018A79 RID: 100985 RVA: 0x00395AA9 File Offset: 0x00393CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06018A7A RID: 100986 RVA: 0x00395AB1 File Offset: 0x00393CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowPasserByNpcNotify);
		}

		// Token: 0x06018A7B RID: 100987 RVA: 0x00395AC0 File Offset: 0x00393CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowPasserByNpcNotify other)
		{
			return other != null && (other == this || (this.IsHide == other.IsHide && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A7C RID: 100988 RVA: 0x00395B10 File Offset: 0x00393D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsHide)
			{
				num ^= this.IsHide.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A7D RID: 100989 RVA: 0x00395B5D File Offset: 0x00393D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A7E RID: 100990 RVA: 0x00395B6A File Offset: 0x00393D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A7F RID: 100991 RVA: 0x00395B74 File Offset: 0x00393D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsHide)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsHide);
			}
			this.entityIds_.WriteTo(ref output, ShowPasserByNpcNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A80 RID: 100992 RVA: 0x00395BC4 File Offset: 0x00393DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsHide)
			{
				num += 2;
			}
			num += this.entityIds_.CalculateSize(ShowPasserByNpcNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A81 RID: 100993 RVA: 0x00395C0C File Offset: 0x00393E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowPasserByNpcNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsHide)
			{
				this.IsHide = other.IsHide;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A82 RID: 100994 RVA: 0x00395C59 File Offset: 0x00393E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A83 RID: 100995 RVA: 0x00395C64 File Offset: 0x00393E64
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
				if (num != 80U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, ShowPasserByNpcNotify._repeated_entityIds_codec);
					}
				}
				else
				{
					this.IsHide = input.ReadBool();
				}
			}
		}

		// Token: 0x0400919E RID: 37278
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400919F RID: 37279
		public const int IsHideFieldNumber = 10;

		// Token: 0x040091A0 RID: 37280
		private bool isHide_;

		// Token: 0x040091A1 RID: 37281
		public const int EntityIdsFieldNumber = 13;

		// Token: 0x040091A2 RID: 37282
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x040091A3 RID: 37283
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
