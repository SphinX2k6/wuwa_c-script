using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F4 RID: 1012
	[NetMessage(EMessageId.DollGrabRequest)]
	public sealed class DollGrabRequest : IMessage<DollGrabRequest>, IMessage, IEquatable<DollGrabRequest>, IDeepCloneable<DollGrabRequest>, IBufferMessage
	{
		// Token: 0x060061F7 RID: 25079 RVA: 0x000EC151 File Offset: 0x000EA351
		[NullableContext(1)]
		public static DollGrabRequest Create()
		{
			return new DollGrabRequest();
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060061F8 RID: 25080 RVA: 0x000EC158 File Offset: 0x000EA358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x000EC15B File Offset: 0x000EA35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabRequest.Descriptor;
			}
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x000EC162 File Offset: 0x000EA362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest()
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x000EC16A File Offset: 0x000EA36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest(DollGrabRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.itemUniId_ = other.itemUniId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x000EC19B File Offset: 0x000EA39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest Clone()
		{
			return new DollGrabRequest(this);
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x000EC1A3 File Offset: 0x000EA3A3
		// (set) Token: 0x060061FE RID: 25086 RVA: 0x000EC1AB File Offset: 0x000EA3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x000EC1B4 File Offset: 0x000EA3B4
		// (set) Token: 0x06006200 RID: 25088 RVA: 0x000EC1BC File Offset: 0x000EA3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUniId
		{
			get
			{
				return this.itemUniId_;
			}
			set
			{
				this.itemUniId_ = value;
			}
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x000EC1C5 File Offset: 0x000EA3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabRequest);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x000EC1D3 File Offset: 0x000EA3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.ItemUniId == other.ItemUniId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x000EC214 File Offset: 0x000EA414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ItemUniId != 0)
			{
				num ^= this.ItemUniId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x000EC26C File Offset: 0x000EA46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x000EC279 File Offset: 0x000EA479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x000EC284 File Offset: 0x000EA484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUniId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUniId);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x000EC2E0 File Offset: 0x000EA4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ItemUniId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUniId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x000EC338 File Offset: 0x000EA538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ItemUniId != 0)
			{
				this.ItemUniId = other.ItemUniId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x000EC388 File Offset: 0x000EA588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x000EC394 File Offset: 0x000EA594
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ItemUniId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037BA RID: 14266
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037BB RID: 14267
		public const int EntityIncIdFieldNumber = 15;

		// Token: 0x040037BC RID: 14268
		private long entityIncId_;

		// Token: 0x040037BD RID: 14269
		public const int ItemUniIdFieldNumber = 3;

		// Token: 0x040037BE RID: 14270
		private int itemUniId_;
	}
}
