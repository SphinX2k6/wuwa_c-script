using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001063 RID: 4195
	[NetMessage(EMessageId.RoleFavorListNotify)]
	public sealed class RoleFavorListNotify : IMessage<RoleFavorListNotify>, IMessage, IEquatable<RoleFavorListNotify>, IDeepCloneable<RoleFavorListNotify>, IBufferMessage
	{
		// Token: 0x06016724 RID: 91940 RVA: 0x0034411A File Offset: 0x0034231A
		[NullableContext(1)]
		public static RoleFavorListNotify Create()
		{
			return new RoleFavorListNotify();
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x06016725 RID: 91941 RVA: 0x00344121 File Offset: 0x00342321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x06016726 RID: 91942 RVA: 0x00344124 File Offset: 0x00342324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListNotify.Descriptor;
			}
		}

		// Token: 0x06016727 RID: 91943 RVA: 0x0034412B File Offset: 0x0034232B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify()
		{
		}

		// Token: 0x06016728 RID: 91944 RVA: 0x00344149 File Offset: 0x00342349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify(RoleFavorListNotify other) : this()
		{
			this.favorList_ = other.favorList_.Clone();
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016729 RID: 91945 RVA: 0x00344184 File Offset: 0x00342384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListNotify Clone()
		{
			return new RoleFavorListNotify(this);
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x0601672A RID: 91946 RVA: 0x0034418C File Offset: 0x0034238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFavor> FavorList
		{
			get
			{
				return this.favorList_;
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0601672B RID: 91947 RVA: 0x00344194 File Offset: 0x00342394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x0601672C RID: 91948 RVA: 0x0034419C File Offset: 0x0034239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListNotify);
		}

		// Token: 0x0601672D RID: 91949 RVA: 0x003441AC File Offset: 0x003423AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListNotify other)
		{
			return other != null && (other == this || (this.favorList_.Equals(other.favorList_) && this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601672E RID: 91950 RVA: 0x00344200 File Offset: 0x00342400
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

		// Token: 0x0601672F RID: 91951 RVA: 0x00344242 File Offset: 0x00342442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016730 RID: 91952 RVA: 0x0034424F File Offset: 0x0034244F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016731 RID: 91953 RVA: 0x00344258 File Offset: 0x00342458
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

		// Token: 0x06016732 RID: 91954 RVA: 0x00344290 File Offset: 0x00342490
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

		// Token: 0x06016733 RID: 91955 RVA: 0x003442DC File Offset: 0x003424DC
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

		// Token: 0x06016734 RID: 91956 RVA: 0x0034431B File Offset: 0x0034251B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016735 RID: 91957 RVA: 0x00344324 File Offset: 0x00342524
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
					if (num != 82U)
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

		// Token: 0x040086BE RID: 34494
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086BF RID: 34495
		public const int FavorListFieldNumber = 10;

		// Token: 0x040086C0 RID: 34496
		private static readonly FieldCodec<RoleFavor> _repeated_favorList_codec = FieldCodec.ForMessage<RoleFavor>(82U, RoleFavor.Parser);

		// Token: 0x040086C1 RID: 34497
		private readonly RepeatedField<RoleFavor> favorList_ = new RepeatedField<RoleFavor>();

		// Token: 0x040086C2 RID: 34498
		public const int RoleConditionInfoMapFieldNumber = 2;

		// Token: 0x040086C3 RID: 34499
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 18U);

		// Token: 0x040086C4 RID: 34500
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}
