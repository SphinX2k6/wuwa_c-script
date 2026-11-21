using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDC RID: 3292
	[NetMessage(EMessageId.PhantomMusicSwitchRequest)]
	public sealed class PhantomMusicSwitchRequest : IMessage<PhantomMusicSwitchRequest>, IMessage, IEquatable<PhantomMusicSwitchRequest>, IDeepCloneable<PhantomMusicSwitchRequest>, IBufferMessage
	{
		// Token: 0x06011D4A RID: 73034 RVA: 0x0029C345 File Offset: 0x0029A545
		[NullableContext(1)]
		public static PhantomMusicSwitchRequest Create()
		{
			return new PhantomMusicSwitchRequest();
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x06011D4B RID: 73035 RVA: 0x0029C34C File Offset: 0x0029A54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x06011D4C RID: 73036 RVA: 0x0029C34F File Offset: 0x0029A54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSwitchRequest.Descriptor;
			}
		}

		// Token: 0x06011D4D RID: 73037 RVA: 0x0029C356 File Offset: 0x0029A556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest()
		{
		}

		// Token: 0x06011D4E RID: 73038 RVA: 0x0029C35E File Offset: 0x0029A55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest(PhantomMusicSwitchRequest other) : this()
		{
			this.musicId_ = other.musicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D4F RID: 73039 RVA: 0x0029C383 File Offset: 0x0029A583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest Clone()
		{
			return new PhantomMusicSwitchRequest(this);
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x06011D50 RID: 73040 RVA: 0x0029C38B File Offset: 0x0029A58B
		// (set) Token: 0x06011D51 RID: 73041 RVA: 0x0029C393 File Offset: 0x0029A593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MusicId
		{
			get
			{
				return this.musicId_;
			}
			set
			{
				this.musicId_ = value;
			}
		}

		// Token: 0x06011D52 RID: 73042 RVA: 0x0029C39C File Offset: 0x0029A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSwitchRequest);
		}

		// Token: 0x06011D53 RID: 73043 RVA: 0x0029C3AA File Offset: 0x0029A5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSwitchRequest other)
		{
			return other != null && (other == this || (this.MusicId == other.MusicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D54 RID: 73044 RVA: 0x0029C3D8 File Offset: 0x0029A5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MusicId != 0)
			{
				num ^= this.MusicId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D55 RID: 73045 RVA: 0x0029C417 File Offset: 0x0029A617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D56 RID: 73046 RVA: 0x0029C424 File Offset: 0x0029A624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D57 RID: 73047 RVA: 0x0029C42D File Offset: 0x0029A62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MusicId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MusicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D58 RID: 73048 RVA: 0x0029C460 File Offset: 0x0029A660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MusicId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MusicId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D59 RID: 73049 RVA: 0x0029C49E File Offset: 0x0029A69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MusicId != 0)
			{
				this.MusicId = other.MusicId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D5A RID: 73050 RVA: 0x0029C4CF File Offset: 0x0029A6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D5B RID: 73051 RVA: 0x0029C4D8 File Offset: 0x0029A6D8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MusicId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400705A RID: 28762
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400705B RID: 28763
		public const int MusicIdFieldNumber = 5;

		// Token: 0x0400705C RID: 28764
		private int musicId_;
	}
}
