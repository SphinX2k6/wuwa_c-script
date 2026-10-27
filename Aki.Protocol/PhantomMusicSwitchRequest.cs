using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEC RID: 3308
	[NetMessage(EMessageId.PhantomMusicSwitchRequest)]
	public sealed class PhantomMusicSwitchRequest : IMessage<PhantomMusicSwitchRequest>, IMessage, IEquatable<PhantomMusicSwitchRequest>, IDeepCloneable<PhantomMusicSwitchRequest>, IBufferMessage
	{
		// Token: 0x06011E46 RID: 73286 RVA: 0x0029DF5D File Offset: 0x0029C15D
		[NullableContext(1)]
		public static PhantomMusicSwitchRequest Create()
		{
			return new PhantomMusicSwitchRequest();
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x06011E47 RID: 73287 RVA: 0x0029DF64 File Offset: 0x0029C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x06011E48 RID: 73288 RVA: 0x0029DF67 File Offset: 0x0029C167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSwitchRequest.Descriptor;
			}
		}

		// Token: 0x06011E49 RID: 73289 RVA: 0x0029DF6E File Offset: 0x0029C16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest()
		{
		}

		// Token: 0x06011E4A RID: 73290 RVA: 0x0029DF76 File Offset: 0x0029C176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest(PhantomMusicSwitchRequest other) : this()
		{
			this.musicId_ = other.musicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E4B RID: 73291 RVA: 0x0029DF9B File Offset: 0x0029C19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchRequest Clone()
		{
			return new PhantomMusicSwitchRequest(this);
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x06011E4C RID: 73292 RVA: 0x0029DFA3 File Offset: 0x0029C1A3
		// (set) Token: 0x06011E4D RID: 73293 RVA: 0x0029DFAB File Offset: 0x0029C1AB
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

		// Token: 0x06011E4E RID: 73294 RVA: 0x0029DFB4 File Offset: 0x0029C1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSwitchRequest);
		}

		// Token: 0x06011E4F RID: 73295 RVA: 0x0029DFC2 File Offset: 0x0029C1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSwitchRequest other)
		{
			return other != null && (other == this || (this.MusicId == other.MusicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E50 RID: 73296 RVA: 0x0029DFF0 File Offset: 0x0029C1F0
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

		// Token: 0x06011E51 RID: 73297 RVA: 0x0029E02F File Offset: 0x0029C22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E52 RID: 73298 RVA: 0x0029E03C File Offset: 0x0029C23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E53 RID: 73299 RVA: 0x0029E045 File Offset: 0x0029C245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MusicId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MusicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E54 RID: 73300 RVA: 0x0029E078 File Offset: 0x0029C278
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

		// Token: 0x06011E55 RID: 73301 RVA: 0x0029E0B6 File Offset: 0x0029C2B6
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

		// Token: 0x06011E56 RID: 73302 RVA: 0x0029E0E7 File Offset: 0x0029C2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E57 RID: 73303 RVA: 0x0029E0F0 File Offset: 0x0029C2F0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MusicId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007042 RID: 28738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007043 RID: 28739
		public const int MusicIdFieldNumber = 9;

		// Token: 0x04007044 RID: 28740
		private int musicId_;
	}
}
