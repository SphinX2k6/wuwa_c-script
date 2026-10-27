using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A8 RID: 4264
	[NetMessage(EMessageId.RoleSexChangeRequest)]
	public sealed class RoleSexChangeRequest : IMessage<RoleSexChangeRequest>, IMessage, IEquatable<RoleSexChangeRequest>, IDeepCloneable<RoleSexChangeRequest>, IBufferMessage
	{
		// Token: 0x06016C55 RID: 93269 RVA: 0x0034F231 File Offset: 0x0034D431
		[NullableContext(1)]
		public static RoleSexChangeRequest Create()
		{
			return new RoleSexChangeRequest();
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x06016C56 RID: 93270 RVA: 0x0034F238 File Offset: 0x0034D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x06016C57 RID: 93271 RVA: 0x0034F23B File Offset: 0x0034D43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSexChangeRequest.Descriptor;
			}
		}

		// Token: 0x06016C58 RID: 93272 RVA: 0x0034F242 File Offset: 0x0034D442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest()
		{
		}

		// Token: 0x06016C59 RID: 93273 RVA: 0x0034F24A File Offset: 0x0034D44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest(RoleSexChangeRequest other) : this()
		{
			this.sex_ = other.sex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C5A RID: 93274 RVA: 0x0034F26F File Offset: 0x0034D46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest Clone()
		{
			return new RoleSexChangeRequest(this);
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x06016C5B RID: 93275 RVA: 0x0034F277 File Offset: 0x0034D477
		// (set) Token: 0x06016C5C RID: 93276 RVA: 0x0034F27F File Offset: 0x0034D47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x0034F288 File Offset: 0x0034D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSexChangeRequest);
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x0034F296 File Offset: 0x0034D496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSexChangeRequest other)
		{
			return other != null && (other == this || (this.Sex == other.Sex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C5F RID: 93279 RVA: 0x0034F2C4 File Offset: 0x0034D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C60 RID: 93280 RVA: 0x0034F303 File Offset: 0x0034D503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C61 RID: 93281 RVA: 0x0034F310 File Offset: 0x0034D510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C62 RID: 93282 RVA: 0x0034F319 File Offset: 0x0034D519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Sex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Sex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C63 RID: 93283 RVA: 0x0034F34C File Offset: 0x0034D54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C64 RID: 93284 RVA: 0x0034F38A File Offset: 0x0034D58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSexChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C65 RID: 93285 RVA: 0x0034F3BB File Offset: 0x0034D5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C66 RID: 93286 RVA: 0x0034F3C4 File Offset: 0x0034D5C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Sex = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087FA RID: 34810
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087FB RID: 34811
		public const int SexFieldNumber = 3;

		// Token: 0x040087FC RID: 34812
		private int sex_;
	}
}
