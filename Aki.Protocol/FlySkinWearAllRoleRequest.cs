using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FC RID: 1532
	[NetMessage(EMessageId.FlySkinWearAllRoleRequest)]
	public sealed class FlySkinWearAllRoleRequest : IMessage<FlySkinWearAllRoleRequest>, IMessage, IEquatable<FlySkinWearAllRoleRequest>, IDeepCloneable<FlySkinWearAllRoleRequest>, IBufferMessage
	{
		// Token: 0x06008E14 RID: 36372 RVA: 0x00158CC9 File Offset: 0x00156EC9
		[NullableContext(1)]
		public static FlySkinWearAllRoleRequest Create()
		{
			return new FlySkinWearAllRoleRequest();
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00158CD0 File Offset: 0x00156ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x00158CD3 File Offset: 0x00156ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearAllRoleRequest.Descriptor;
			}
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00158CDA File Offset: 0x00156EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest()
		{
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00158CE2 File Offset: 0x00156EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest(FlySkinWearAllRoleRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00158D07 File Offset: 0x00156F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest Clone()
		{
			return new FlySkinWearAllRoleRequest(this);
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x00158D0F File Offset: 0x00156F0F
		// (set) Token: 0x06008E1B RID: 36379 RVA: 0x00158D17 File Offset: 0x00156F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06008E1C RID: 36380 RVA: 0x00158D20 File Offset: 0x00156F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearAllRoleRequest);
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x00158D2E File Offset: 0x00156F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearAllRoleRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x00158D5C File Offset: 0x00156F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x00158D9B File Offset: 0x00156F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x00158DA8 File Offset: 0x00156FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x00158DB1 File Offset: 0x00156FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x00158DE4 File Offset: 0x00156FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00158E22 File Offset: 0x00157022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearAllRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x00158E53 File Offset: 0x00157053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x00158E5C File Offset: 0x0015705C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400459D RID: 17821
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400459E RID: 17822
		public const int SkinIdFieldNumber = 14;

		// Token: 0x0400459F RID: 17823
		private int skinId_;
	}
}
