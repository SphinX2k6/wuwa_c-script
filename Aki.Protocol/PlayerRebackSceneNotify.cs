using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA5 RID: 3493
	[NetMessage(EMessageId.PlayerRebackSceneNotify)]
	public sealed class PlayerRebackSceneNotify : IMessage<PlayerRebackSceneNotify>, IMessage, IEquatable<PlayerRebackSceneNotify>, IDeepCloneable<PlayerRebackSceneNotify>, IBufferMessage
	{
		// Token: 0x06012D20 RID: 77088 RVA: 0x002BEAAC File Offset: 0x002BCCAC
		[NullableContext(1)]
		public static PlayerRebackSceneNotify Create()
		{
			return new PlayerRebackSceneNotify();
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x06012D21 RID: 77089 RVA: 0x002BEAB3 File Offset: 0x002BCCB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x06012D22 RID: 77090 RVA: 0x002BEAB6 File Offset: 0x002BCCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRebackSceneNotify.Descriptor;
			}
		}

		// Token: 0x06012D23 RID: 77091 RVA: 0x002BEABD File Offset: 0x002BCCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify()
		{
		}

		// Token: 0x06012D24 RID: 77092 RVA: 0x002BEAC5 File Offset: 0x002BCCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify(PlayerRebackSceneNotify other) : this()
		{
			this.curControlEntityId_ = other.curControlEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D25 RID: 77093 RVA: 0x002BEAEA File Offset: 0x002BCCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify Clone()
		{
			return new PlayerRebackSceneNotify(this);
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x06012D26 RID: 77094 RVA: 0x002BEAF2 File Offset: 0x002BCCF2
		// (set) Token: 0x06012D27 RID: 77095 RVA: 0x002BEAFA File Offset: 0x002BCCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurControlEntityId
		{
			get
			{
				return this.curControlEntityId_;
			}
			set
			{
				this.curControlEntityId_ = value;
			}
		}

		// Token: 0x06012D28 RID: 77096 RVA: 0x002BEB03 File Offset: 0x002BCD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRebackSceneNotify);
		}

		// Token: 0x06012D29 RID: 77097 RVA: 0x002BEB11 File Offset: 0x002BCD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRebackSceneNotify other)
		{
			return other != null && (other == this || (this.CurControlEntityId == other.CurControlEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D2A RID: 77098 RVA: 0x002BEB40 File Offset: 0x002BCD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurControlEntityId != 0L)
			{
				num ^= this.CurControlEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D2B RID: 77099 RVA: 0x002BEB7F File Offset: 0x002BCD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D2C RID: 77100 RVA: 0x002BEB8C File Offset: 0x002BCD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D2D RID: 77101 RVA: 0x002BEB95 File Offset: 0x002BCD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurControlEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurControlEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D2E RID: 77102 RVA: 0x002BEBC8 File Offset: 0x002BCDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurControlEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurControlEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D2F RID: 77103 RVA: 0x002BEC06 File Offset: 0x002BCE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRebackSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurControlEntityId != 0L)
			{
				this.CurControlEntityId = other.CurControlEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D30 RID: 77104 RVA: 0x002BEC37 File Offset: 0x002BCE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D31 RID: 77105 RVA: 0x002BEC40 File Offset: 0x002BCE40
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurControlEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007480 RID: 29824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007481 RID: 29825
		public const int CurControlEntityIdFieldNumber = 12;

		// Token: 0x04007482 RID: 29826
		private long curControlEntityId_;
	}
}
