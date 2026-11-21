using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012D RID: 301
	[NetMessage(EMessageId.AttributeInitResponse)]
	public sealed class AttributeInitResponse : IMessage<AttributeInitResponse>, IMessage, IEquatable<AttributeInitResponse>, IDeepCloneable<AttributeInitResponse>, IBufferMessage
	{
		// Token: 0x06002824 RID: 10276 RVA: 0x0006A190 File Offset: 0x00068390
		[NullableContext(1)]
		public static AttributeInitResponse Create()
		{
			return new AttributeInitResponse();
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x0006A197 File Offset: 0x00068397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0006A19A File Offset: 0x0006839A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitResponse.Descriptor;
			}
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0006A1A1 File Offset: 0x000683A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse()
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0006A1A9 File Offset: 0x000683A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse(AttributeInitResponse other) : this()
		{
			this.success_ = other.success_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0006A1DA File Offset: 0x000683DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitResponse Clone()
		{
			return new AttributeInitResponse(this);
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0006A1E2 File Offset: 0x000683E2
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0006A1EA File Offset: 0x000683EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x0006A1F3 File Offset: 0x000683F3
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x0006A1FB File Offset: 0x000683FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0006A204 File Offset: 0x00068404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitResponse);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0006A212 File Offset: 0x00068412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitResponse other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x0006A250 File Offset: 0x00068450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0006A2A8 File Offset: 0x000684A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x0006A2B5 File Offset: 0x000684B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0006A2C0 File Offset: 0x000684C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Success)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Success);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0006A31C File Offset: 0x0006851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0006A368 File Offset: 0x00068568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeInitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0006A3B8 File Offset: 0x000685B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0006A3C4 File Offset: 0x000685C4
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x040026E5 RID: 9957
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E6 RID: 9958
		public const int SuccessFieldNumber = 10;

		// Token: 0x040026E7 RID: 9959
		private bool success_;

		// Token: 0x040026E8 RID: 9960
		public const int IdFieldNumber = 11;

		// Token: 0x040026E9 RID: 9961
		private long id_;
	}
}
