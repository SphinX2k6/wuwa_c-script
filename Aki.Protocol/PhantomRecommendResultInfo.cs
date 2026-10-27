using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF8 RID: 3320
	public sealed class PhantomRecommendResultInfo : IMessage<PhantomRecommendResultInfo>, IMessage, IEquatable<PhantomRecommendResultInfo>, IDeepCloneable<PhantomRecommendResultInfo>, IBufferMessage
	{
		// Token: 0x06011F3E RID: 73534 RVA: 0x002A0236 File Offset: 0x0029E436
		[NullableContext(1)]
		public static PhantomRecommendResultInfo Create()
		{
			return new PhantomRecommendResultInfo();
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x06011F3F RID: 73535 RVA: 0x002A023D File Offset: 0x0029E43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x06011F40 RID: 73536 RVA: 0x002A0240 File Offset: 0x0029E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendResultInfo.Descriptor;
			}
		}

		// Token: 0x06011F41 RID: 73537 RVA: 0x002A0247 File Offset: 0x0029E447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo()
		{
		}

		// Token: 0x06011F42 RID: 73538 RVA: 0x002A025A File Offset: 0x0029E45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo(PhantomRecommendResultInfo other) : this()
		{
			this.rolePhantomRecommendInfos_ = other.rolePhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F43 RID: 73539 RVA: 0x002A0284 File Offset: 0x0029E484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResultInfo Clone()
		{
			return new PhantomRecommendResultInfo(this);
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x06011F44 RID: 73540 RVA: 0x002A028C File Offset: 0x0029E48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RolePhantomRecommendInfo> RolePhantomRecommendInfos
		{
			get
			{
				return this.rolePhantomRecommendInfos_;
			}
		}

		// Token: 0x06011F45 RID: 73541 RVA: 0x002A0294 File Offset: 0x0029E494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendResultInfo);
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x002A02A2 File Offset: 0x0029E4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendResultInfo other)
		{
			return other != null && (other == this || (this.RolePhantomRecommendInfos.Equals(other.RolePhantomRecommendInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x002A02D8 File Offset: 0x0029E4D8
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

		// Token: 0x06011F48 RID: 73544 RVA: 0x002A030C File Offset: 0x0029E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x002A0319 File Offset: 0x0029E519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x002A0322 File Offset: 0x0029E522
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

		// Token: 0x06011F4B RID: 73547 RVA: 0x002A034C File Offset: 0x0029E54C
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

		// Token: 0x06011F4C RID: 73548 RVA: 0x002A0385 File Offset: 0x0029E585
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

		// Token: 0x06011F4D RID: 73549 RVA: 0x002A03B3 File Offset: 0x0029E5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F4E RID: 73550 RVA: 0x002A03BC File Offset: 0x0029E5BC
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

		// Token: 0x0400708E RID: 28814
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400708F RID: 28815
		public const int RolePhantomRecommendInfosFieldNumber = 1;

		// Token: 0x04007090 RID: 28816
		private static readonly MapField<int, RolePhantomRecommendInfo>.Codec _map_rolePhantomRecommendInfos_codec = new MapField<int, RolePhantomRecommendInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RolePhantomRecommendInfo>(18U, RolePhantomRecommendInfo.Parser), 10U);

		// Token: 0x04007091 RID: 28817
		private readonly MapField<int, RolePhantomRecommendInfo> rolePhantomRecommendInfos_ = new MapField<int, RolePhantomRecommendInfo>();
	}
}
