using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001061 RID: 4193
	[NetMessage(EMessageId.RoleFavorFinishConditionNotify)]
	public sealed class RoleFavorFinishConditionNotify : IMessage<RoleFavorFinishConditionNotify>, IMessage, IEquatable<RoleFavorFinishConditionNotify>, IDeepCloneable<RoleFavorFinishConditionNotify>, IBufferMessage
	{
		// Token: 0x060166FC RID: 91900 RVA: 0x00343BE7 File Offset: 0x00341DE7
		[NullableContext(1)]
		public static RoleFavorFinishConditionNotify Create()
		{
			return new RoleFavorFinishConditionNotify();
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x060166FD RID: 91901 RVA: 0x00343BEE File Offset: 0x00341DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x060166FE RID: 91902 RVA: 0x00343BF1 File Offset: 0x00341DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorFinishConditionNotify.Descriptor;
			}
		}

		// Token: 0x060166FF RID: 91903 RVA: 0x00343BF8 File Offset: 0x00341DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify()
		{
		}

		// Token: 0x06016700 RID: 91904 RVA: 0x00343C0B File Offset: 0x00341E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify(RoleFavorFinishConditionNotify other) : this()
		{
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016701 RID: 91905 RVA: 0x00343C35 File Offset: 0x00341E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify Clone()
		{
			return new RoleFavorFinishConditionNotify(this);
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x06016702 RID: 91906 RVA: 0x00343C3D File Offset: 0x00341E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x06016703 RID: 91907 RVA: 0x00343C45 File Offset: 0x00341E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorFinishConditionNotify);
		}

		// Token: 0x06016704 RID: 91908 RVA: 0x00343C53 File Offset: 0x00341E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorFinishConditionNotify other)
		{
			return other != null && (other == this || (this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016705 RID: 91909 RVA: 0x00343C88 File Offset: 0x00341E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016706 RID: 91910 RVA: 0x00343CBC File Offset: 0x00341EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016707 RID: 91911 RVA: 0x00343CC9 File Offset: 0x00341EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016708 RID: 91912 RVA: 0x00343CD2 File Offset: 0x00341ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConditionInfoMap_.WriteTo(ref output, RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016709 RID: 91913 RVA: 0x00343CFC File Offset: 0x00341EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConditionInfoMap_.CalculateSize(RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601670A RID: 91914 RVA: 0x00343D35 File Offset: 0x00341F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorFinishConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601670B RID: 91915 RVA: 0x00343D63 File Offset: 0x00341F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601670C RID: 91916 RVA: 0x00343D6C File Offset: 0x00341F6C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
				}
			}
		}

		// Token: 0x040086B3 RID: 34483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086B4 RID: 34484
		public const int RoleConditionInfoMapFieldNumber = 1;

		// Token: 0x040086B5 RID: 34485
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 10U);

		// Token: 0x040086B6 RID: 34486
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}
