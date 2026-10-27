using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001073 RID: 4211
	[NetMessage(EMessageId.RoleFavorListNotify)]
	public sealed class RoleFavorListNotify : IMessage<RoleFavorListNotify>, IMessage, IEquatable<RoleFavorListNotify>, IDeepCloneable<RoleFavorListNotify>, IBufferMessage
	{
		// Token: 0x06016809 RID: 92169 RVA: 0x003457EF File Offset: 0x003439EF
		[NullableContext(1)]
		public static RoleFavorListNotify Create()
		{
			return new RoleFavorListNotify();
		}

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x0601680A RID: 92170 RVA: 0x003457F6 File Offset: 0x003439F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x0601680B RID: 92171 RVA: 0x003457F9 File Offset: 0x003439F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListNotify.Descriptor;
			}
		}

		// Token: 0x0601680C RID: 92172 RVA: 0x00345800 File Offset: 0x00343A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify()
		{
		}

		// Token: 0x0601680D RID: 92173 RVA: 0x0034581E File Offset: 0x00343A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify(RoleFavorListNotify other) : this()
		{
			this.favorList_ = other.favorList_.Clone();
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601680E RID: 92174 RVA: 0x00345859 File Offset: 0x00343A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify Clone()
		{
			return new RoleFavorListNotify(this);
		}

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x0601680F RID: 92175 RVA: 0x00345861 File Offset: 0x00343A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFavor> FavorList
		{
			get
			{
				return this.favorList_;
			}
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06016810 RID: 92176 RVA: 0x00345869 File Offset: 0x00343A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x06016811 RID: 92177 RVA: 0x00345871 File Offset: 0x00343A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListNotify);
		}

		// Token: 0x06016812 RID: 92178 RVA: 0x00345880 File Offset: 0x00343A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListNotify other)
		{
			return other != null && (other == this || (this.favorList_.Equals(other.favorList_) && this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016813 RID: 92179 RVA: 0x003458D4 File Offset: 0x00343AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.favorList_.GetHashCode();
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016814 RID: 92180 RVA: 0x00345916 File Offset: 0x00343B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016815 RID: 92181 RVA: 0x00345923 File Offset: 0x00343B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016816 RID: 92182 RVA: 0x0034592C File Offset: 0x00343B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConditionInfoMap_.WriteTo(ref output, RoleFavorListNotify._map_roleConditionInfoMap_codec);
			this.favorList_.WriteTo(ref output, RoleFavorListNotify._repeated_favorList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016817 RID: 92183 RVA: 0x00345964 File Offset: 0x00343B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.favorList_.CalculateSize(RoleFavorListNotify._repeated_favorList_codec);
			num += this.roleConditionInfoMap_.CalculateSize(RoleFavorListNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016818 RID: 92184 RVA: 0x003459B0 File Offset: 0x00343BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.favorList_.Add(other.favorList_);
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016819 RID: 92185 RVA: 0x003459EF File Offset: 0x00343BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601681A RID: 92186 RVA: 0x003459F8 File Offset: 0x00343BF8
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.favorList_.AddEntriesFrom(ref input, RoleFavorListNotify._repeated_favorList_codec);
					}
				}
				else
				{
					this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleFavorListNotify._map_roleConditionInfoMap_codec);
				}
			}
		}

		// Token: 0x04008694 RID: 34452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008695 RID: 34453
		public const int FavorListFieldNumber = 12;

		// Token: 0x04008696 RID: 34454
		private static readonly FieldCodec<RoleFavor> _repeated_favorList_codec = FieldCodec.ForMessage<RoleFavor>(98U, RoleFavor.Parser);

		// Token: 0x04008697 RID: 34455
		private readonly RepeatedField<RoleFavor> favorList_ = new RepeatedField<RoleFavor>();

		// Token: 0x04008698 RID: 34456
		public const int RoleConditionInfoMapFieldNumber = 10;

		// Token: 0x04008699 RID: 34457
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 82U);

		// Token: 0x0400869A RID: 34458
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}
