using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CB RID: 971
	[NetMessage(EMessageId.DissolveCombineRelationRequest)]
	public sealed class DissolveCombineRelationRequest : IMessage<DissolveCombineRelationRequest>, IMessage, IEquatable<DissolveCombineRelationRequest>, IDeepCloneable<DissolveCombineRelationRequest>, IBufferMessage
	{
		// Token: 0x06005F11 RID: 24337 RVA: 0x000E67B6 File Offset: 0x000E49B6
		[NullableContext(1)]
		public static DissolveCombineRelationRequest Create()
		{
			return new DissolveCombineRelationRequest();
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005F12 RID: 24338 RVA: 0x000E67BD File Offset: 0x000E49BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x000E67C0 File Offset: 0x000E49C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveCombineRelationRequest.Descriptor;
			}
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x000E67C7 File Offset: 0x000E49C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest()
		{
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x000E67CF File Offset: 0x000E49CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest(DissolveCombineRelationRequest other) : this()
		{
			this.entityA_ = other.entityA_;
			this.entityB_ = other.entityB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x000E6800 File Offset: 0x000E4A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest Clone()
		{
			return new DissolveCombineRelationRequest(this);
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06005F17 RID: 24343 RVA: 0x000E6808 File Offset: 0x000E4A08
		// (set) Token: 0x06005F18 RID: 24344 RVA: 0x000E6810 File Offset: 0x000E4A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityA
		{
			get
			{
				return this.entityA_;
			}
			set
			{
				this.entityA_ = value;
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x000E6819 File Offset: 0x000E4A19
		// (set) Token: 0x06005F1A RID: 24346 RVA: 0x000E6821 File Offset: 0x000E4A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityB
		{
			get
			{
				return this.entityB_;
			}
			set
			{
				this.entityB_ = value;
			}
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x000E682A File Offset: 0x000E4A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveCombineRelationRequest);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x000E6838 File Offset: 0x000E4A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DissolveCombineRelationRequest other)
		{
			return other != null && (other == this || (this.EntityA == other.EntityA && this.EntityB == other.EntityB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x000E6878 File Offset: 0x000E4A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityA != 0L)
			{
				num ^= this.EntityA.GetHashCode();
			}
			if (this.EntityB != 0L)
			{
				num ^= this.EntityB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x000E68D0 File Offset: 0x000E4AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x000E68DD File Offset: 0x000E4ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x000E68E8 File Offset: 0x000E4AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityA != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityA);
			}
			if (this.EntityB != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x000E6944 File Offset: 0x000E4B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityA != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityA);
			}
			if (this.EntityB != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x000E699C File Offset: 0x000E4B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DissolveCombineRelationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityA != 0L)
			{
				this.EntityA = other.EntityA;
			}
			if (other.EntityB != 0L)
			{
				this.EntityB = other.EntityB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x000E69EC File Offset: 0x000E4BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x000E69F8 File Offset: 0x000E4BF8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityB = input.ReadInt64();
					}
				}
				else
				{
					this.EntityA = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400375A RID: 14170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400375B RID: 14171
		public const int EntityAFieldNumber = 2;

		// Token: 0x0400375C RID: 14172
		private long entityA_;

		// Token: 0x0400375D RID: 14173
		public const int EntityBFieldNumber = 3;

		// Token: 0x0400375E RID: 14174
		private long entityB_;
	}
}
