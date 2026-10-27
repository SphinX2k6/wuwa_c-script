using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C2 RID: 194
	public sealed class AdventureSilentCtx : IMessage<AdventureSilentCtx>, IMessage, IEquatable<AdventureSilentCtx>, IDeepCloneable<AdventureSilentCtx>, IBufferMessage
	{
		// Token: 0x06001EF1 RID: 7921 RVA: 0x0005477D File Offset: 0x0005297D
		[NullableContext(1)]
		public static AdventureSilentCtx Create()
		{
			return new AdventureSilentCtx();
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00054784 File Offset: 0x00052984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00054787 File Offset: 0x00052987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureSilentCtx.Descriptor;
			}
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0005478E File Offset: 0x0005298E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx()
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00054796 File Offset: 0x00052996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx(AdventureSilentCtx other) : this()
		{
			this.adventureSilentId_ = other.adventureSilentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000547BB File Offset: 0x000529BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx Clone()
		{
			return new AdventureSilentCtx(this);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000547C3 File Offset: 0x000529C3
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x000547CB File Offset: 0x000529CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AdventureSilentId
		{
			get
			{
				return this.adventureSilentId_;
			}
			set
			{
				this.adventureSilentId_ = value;
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000547D4 File Offset: 0x000529D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureSilentCtx);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000547E2 File Offset: 0x000529E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureSilentCtx other)
		{
			return other != null && (other == this || (this.AdventureSilentId == other.AdventureSilentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00054810 File Offset: 0x00052A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AdventureSilentId != 0)
			{
				num ^= this.AdventureSilentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0005484F File Offset: 0x00052A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0005485C File Offset: 0x00052A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00054865 File Offset: 0x00052A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AdventureSilentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AdventureSilentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00054898 File Offset: 0x00052A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AdventureSilentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdventureSilentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000548D6 File Offset: 0x00052AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureSilentCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AdventureSilentId != 0)
			{
				this.AdventureSilentId = other.AdventureSilentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00054907 File Offset: 0x00052B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00054910 File Offset: 0x00052B10
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AdventureSilentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400239A RID: 9114
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400239B RID: 9115
		public const int AdventureSilentIdFieldNumber = 1;

		// Token: 0x0400239C RID: 9116
		private int adventureSilentId_;
	}
}
