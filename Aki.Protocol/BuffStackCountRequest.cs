using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020F RID: 527
	[NetMessage(EMessageId.BuffStackCountRequest)]
	public sealed class BuffStackCountRequest : IMessage<BuffStackCountRequest>, IMessage, IEquatable<BuffStackCountRequest>, IDeepCloneable<BuffStackCountRequest>, IBufferMessage
	{
		// Token: 0x06003A42 RID: 14914 RVA: 0x000918E8 File Offset: 0x0008FAE8
		[NullableContext(1)]
		public static BuffStackCountRequest Create()
		{
			return new BuffStackCountRequest();
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x000918EF File Offset: 0x0008FAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x000918F2 File Offset: 0x0008FAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountRequest.Descriptor;
			}
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000918F9 File Offset: 0x0008FAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest()
		{
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00091904 File Offset: 0x0008FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest(BuffStackCountRequest other) : this()
		{
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00091958 File Offset: 0x0008FB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest Clone()
		{
			return new BuffStackCountRequest(this);
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003A48 RID: 14920 RVA: 0x00091960 File Offset: 0x0008FB60
		// (set) Token: 0x06003A49 RID: 14921 RVA: 0x00091968 File Offset: 0x0008FB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x00091971 File Offset: 0x0008FB71
		// (set) Token: 0x06003A4B RID: 14923 RVA: 0x00091979 File Offset: 0x0008FB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewStackCount
		{
			get
			{
				return this.newStackCount_;
			}
			set
			{
				this.newStackCount_ = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x00091982 File Offset: 0x0008FB82
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x0009198A File Offset: 0x0008FB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPrematureRemoval
		{
			get
			{
				return this.isPrematureRemoval_;
			}
			set
			{
				this.isPrematureRemoval_ = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x00091993 File Offset: 0x0008FB93
		// (set) Token: 0x06003A4F RID: 14927 RVA: 0x0009199B File Offset: 0x0008FB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x000919A4 File Offset: 0x0008FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountRequest);
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x000919B4 File Offset: 0x0008FBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountRequest other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && this.IsPrematureRemoval == other.IsPrematureRemoval && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00091A20 File Offset: 0x0008FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.NewStackCount != 0)
			{
				num ^= this.NewStackCount.GetHashCode();
			}
			if (this.IsPrematureRemoval)
			{
				num ^= this.IsPrematureRemoval.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00091AAA File Offset: 0x0008FCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00091AB7 File Offset: 0x0008FCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00091AC0 File Offset: 0x0008FCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.NewStackCount);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HandleId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00091B54 File Offset: 0x0008FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.NewStackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewStackCount);
			}
			if (this.IsPrematureRemoval)
			{
				num += 2;
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00091BD0 File Offset: 0x0008FDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.NewStackCount != 0)
			{
				this.NewStackCount = other.NewStackCount;
			}
			if (other.IsPrematureRemoval)
			{
				this.IsPrematureRemoval = other.IsPrematureRemoval;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00091C48 File Offset: 0x0008FE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00091C54 File Offset: 0x0008FE54
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.IsPrematureRemoval = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HandleId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C1B RID: 11291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C1C RID: 11292
		public const int HandleIdFieldNumber = 11;

		// Token: 0x04002C1D RID: 11293
		private int handleId_;

		// Token: 0x04002C1E RID: 11294
		public const int NewStackCountFieldNumber = 9;

		// Token: 0x04002C1F RID: 11295
		private int newStackCount_;

		// Token: 0x04002C20 RID: 11296
		public const int IsPrematureRemovalFieldNumber = 3;

		// Token: 0x04002C21 RID: 11297
		private bool isPrematureRemoval_;

		// Token: 0x04002C22 RID: 11298
		public const int InstigatorIdFieldNumber = 15;

		// Token: 0x04002C23 RID: 11299
		private long instigatorId_;
	}
}
