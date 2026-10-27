using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000395 RID: 917
	[NetMessage(EMessageId.DarkCoastInfoRequest)]
	public sealed class DarkCoastInfoRequest : IMessage<DarkCoastInfoRequest>, IMessage, IEquatable<DarkCoastInfoRequest>, IDeepCloneable<DarkCoastInfoRequest>, IBufferMessage
	{
		// Token: 0x06005A7D RID: 23165 RVA: 0x000DC264 File Offset: 0x000DA464
		[NullableContext(1)]
		public static DarkCoastInfoRequest Create()
		{
			return new DarkCoastInfoRequest();
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x000DC26B File Offset: 0x000DA46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06005A7F RID: 23167 RVA: 0x000DC26E File Offset: 0x000DA46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkCoastInfoRequest.Descriptor;
			}
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x000DC275 File Offset: 0x000DA475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest()
		{
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x000DC27D File Offset: 0x000DA47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest(DarkCoastInfoRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x000DC2A2 File Offset: 0x000DA4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest Clone()
		{
			return new DarkCoastInfoRequest(this);
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06005A83 RID: 23171 RVA: 0x000DC2AA File Offset: 0x000DA4AA
		// (set) Token: 0x06005A84 RID: 23172 RVA: 0x000DC2B2 File Offset: 0x000DA4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x000DC2BB File Offset: 0x000DA4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkCoastInfoRequest);
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x000DC2C9 File Offset: 0x000DA4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkCoastInfoRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x000DC2F8 File Offset: 0x000DA4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x000DC337 File Offset: 0x000DA537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x000DC344 File Offset: 0x000DA544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x000DC34D File Offset: 0x000DA54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x000DC380 File Offset: 0x000DA580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x000DC3BE File Offset: 0x000DA5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkCoastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x000DC3EF File Offset: 0x000DA5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x000DC3F8 File Offset: 0x000DA5F8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035B7 RID: 13751
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B8 RID: 13752
		public const int DragonPoolIdFieldNumber = 15;

		// Token: 0x040035B9 RID: 13753
		private int dragonPoolId_;
	}
}
