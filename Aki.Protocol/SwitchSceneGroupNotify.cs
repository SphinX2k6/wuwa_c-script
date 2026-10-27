using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001307 RID: 4871
	[NetMessage(EMessageId.SwitchSceneGroupNotify)]
	public sealed class SwitchSceneGroupNotify : IMessage<SwitchSceneGroupNotify>, IMessage, IEquatable<SwitchSceneGroupNotify>, IDeepCloneable<SwitchSceneGroupNotify>, IBufferMessage
	{
		// Token: 0x06019E42 RID: 106050 RVA: 0x003C3134 File Offset: 0x003C1334
		[NullableContext(1)]
		public static SwitchSceneGroupNotify Create()
		{
			return new SwitchSceneGroupNotify();
		}

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x06019E43 RID: 106051 RVA: 0x003C313B File Offset: 0x003C133B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x06019E44 RID: 106052 RVA: 0x003C313E File Offset: 0x003C133E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchSceneGroupNotify.Descriptor;
			}
		}

		// Token: 0x06019E45 RID: 106053 RVA: 0x003C3145 File Offset: 0x003C1345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify()
		{
		}

		// Token: 0x06019E46 RID: 106054 RVA: 0x003C314D File Offset: 0x003C134D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify(SwitchSceneGroupNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.group_ = other.group_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E47 RID: 106055 RVA: 0x003C317E File Offset: 0x003C137E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify Clone()
		{
			return new SwitchSceneGroupNotify(this);
		}

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x06019E48 RID: 106056 RVA: 0x003C3186 File Offset: 0x003C1386
		// (set) Token: 0x06019E49 RID: 106057 RVA: 0x003C318E File Offset: 0x003C138E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x06019E4A RID: 106058 RVA: 0x003C3197 File Offset: 0x003C1397
		// (set) Token: 0x06019E4B RID: 106059 RVA: 0x003C319F File Offset: 0x003C139F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x06019E4C RID: 106060 RVA: 0x003C31A8 File Offset: 0x003C13A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchSceneGroupNotify);
		}

		// Token: 0x06019E4D RID: 106061 RVA: 0x003C31B6 File Offset: 0x003C13B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchSceneGroupNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Group == other.Group && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E4E RID: 106062 RVA: 0x003C31F4 File Offset: 0x003C13F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E4F RID: 106063 RVA: 0x003C324C File Offset: 0x003C144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E50 RID: 106064 RVA: 0x003C3259 File Offset: 0x003C1459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E51 RID: 106065 RVA: 0x003C3264 File Offset: 0x003C1464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Group != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Group);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E52 RID: 106066 RVA: 0x003C32BC File Offset: 0x003C14BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E53 RID: 106067 RVA: 0x003C3314 File Offset: 0x003C1514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchSceneGroupNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E54 RID: 106068 RVA: 0x003C3364 File Offset: 0x003C1564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E55 RID: 106069 RVA: 0x003C3370 File Offset: 0x003C1570
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Group = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400975C RID: 38748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400975D RID: 38749
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400975E RID: 38750
		private int playerId_;

		// Token: 0x0400975F RID: 38751
		public const int GroupFieldNumber = 6;

		// Token: 0x04009760 RID: 38752
		private int group_;
	}
}
