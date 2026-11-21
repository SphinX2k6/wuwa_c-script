using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE8 RID: 3304
	public sealed class PhantomRecommendResultInfo : IMessage<PhantomRecommendResultInfo>, IMessage, IEquatable<PhantomRecommendResultInfo>, IDeepCloneable<PhantomRecommendResultInfo>, IBufferMessage
	{
		// Token: 0x06011E42 RID: 73282 RVA: 0x0029E61E File Offset: 0x0029C81E
		[NullableContext(1)]
		public static PhantomRecommendResultInfo Create()
		{
			return new PhantomRecommendResultInfo();
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x06011E43 RID: 73283 RVA: 0x0029E625 File Offset: 0x0029C825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x06011E44 RID: 73284 RVA: 0x0029E628 File Offset: 0x0029C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendResultInfo.Descriptor;
			}
		}

		// Token: 0x06011E45 RID: 73285 RVA: 0x0029E62F File Offset: 0x0029C82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo()
		{
		}

		// Token: 0x06011E46 RID: 73286 RVA: 0x0029E642 File Offset: 0x0029C842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo(PhantomRecommendResultInfo other) : this()
		{
			this.rolePhantomRecommendInfos_ = other.rolePhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E47 RID: 73287 RVA: 0x0029E66C File Offset: 0x0029C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo Clone()
		{
			return new PhantomRecommendResultInfo(this);
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x06011E48 RID: 73288 RVA: 0x0029E674 File Offset: 0x0029C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RolePhantomRecommendInfo> RolePhantomRecommendInfos
		{
			get
			{
				return this.rolePhantomRecommendInfos_;
			}
		}

		// Token: 0x06011E49 RID: 73289 RVA: 0x0029E67C File Offset: 0x0029C87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendResultInfo);
		}

		// Token: 0x06011E4A RID: 73290 RVA: 0x0029E68A File Offset: 0x0029C88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendResultInfo other)
		{
			return other != null && (other == this || (this.RolePhantomRecommendInfos.Equals(other.RolePhantomRecommendInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E4B RID: 73291 RVA: 0x0029E6C0 File Offset: 0x0029C8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RolePhantomRecommendInfos.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011E4C RID: 73292 RVA: 0x0029E6F4 File Offset: 0x0029C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E4D RID: 73293 RVA: 0x0029E701 File Offset: 0x0029C901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E4E RID: 73294 RVA: 0x0029E70A File Offset: 0x0029C90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rolePhantomRecommendInfos_.WriteTo(ref output, PhantomRecommendResultInfo._map_rolePhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E4F RID: 73295 RVA: 0x0029E734 File Offset: 0x0029C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rolePhantomRecommendInfos_.CalculateSize(PhantomRecommendResultInfo._map_rolePhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E50 RID: 73296 RVA: 0x0029E76D File Offset: 0x0029C96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRecommendResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.rolePhantomRecommendInfos_.MergeFrom(other.rolePhantomRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E51 RID: 73297 RVA: 0x0029E79B File Offset: 0x0029C99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E52 RID: 73298 RVA: 0x0029E7A4 File Offset: 0x0029C9A4
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
					this.rolePhantomRecommendInfos_.AddEntriesFrom(ref input, PhantomRecommendResultInfo._map_rolePhantomRecommendInfos_codec);
				}
			}
		}

		// Token: 0x040070A6 RID: 28838
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070A7 RID: 28839
		public const int RolePhantomRecommendInfosFieldNumber = 1;

		// Token: 0x040070A8 RID: 28840
		private static readonly MapField<int, RolePhantomRecommendInfo>.Codec _map_rolePhantomRecommendInfos_codec = new MapField<int, RolePhantomRecommendInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RolePhantomRecommendInfo>(18U, RolePhantomRecommendInfo.Parser), 10U);

		// Token: 0x040070A9 RID: 28841
		private readonly MapField<int, RolePhantomRecommendInfo> rolePhantomRecommendInfos_ = new MapField<int, RolePhantomRecommendInfo>();
	}
}
