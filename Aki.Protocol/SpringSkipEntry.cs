using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F5 RID: 4853
	public sealed class SpringSkipEntry : IMessage<SpringSkipEntry>, IMessage, IEquatable<SpringSkipEntry>, IDeepCloneable<SpringSkipEntry>, IBufferMessage
	{
		// Token: 0x06019E3B RID: 106043 RVA: 0x003C6A04 File Offset: 0x003C4C04
		[NullableContext(1)]
		public static SpringSkipEntry Create()
		{
			return new SpringSkipEntry();
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x06019E3C RID: 106044 RVA: 0x003C6A0B File Offset: 0x003C4C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringSkipEntry> Parser
		{
			get
			{
				return SpringSkipEntry._parser;
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x06019E3D RID: 106045 RVA: 0x003C6A12 File Offset: 0x003C4C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x06019E3E RID: 106046 RVA: 0x003C6A15 File Offset: 0x003C4C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSkipEntry.Descriptor;
			}
		}

		// Token: 0x06019E3F RID: 106047 RVA: 0x003C6A1C File Offset: 0x003C4C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry()
		{
		}

		// Token: 0x06019E40 RID: 106048 RVA: 0x003C6A24 File Offset: 0x003C4C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry(SpringSkipEntry other) : this()
		{
			this.id_ = other.id_;
			this.unLock_ = other.unLock_;
			this.finish_ = other.finish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E41 RID: 106049 RVA: 0x003C6A61 File Offset: 0x003C4C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry Clone()
		{
			return new SpringSkipEntry(this);
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x06019E42 RID: 106050 RVA: 0x003C6A69 File Offset: 0x003C4C69
		// (set) Token: 0x06019E43 RID: 106051 RVA: 0x003C6A71 File Offset: 0x003C4C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x06019E44 RID: 106052 RVA: 0x003C6A7A File Offset: 0x003C4C7A
		// (set) Token: 0x06019E45 RID: 106053 RVA: 0x003C6A82 File Offset: 0x003C4C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnLock
		{
			get
			{
				return this.unLock_;
			}
			set
			{
				this.unLock_ = value;
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x06019E46 RID: 106054 RVA: 0x003C6A8B File Offset: 0x003C4C8B
		// (set) Token: 0x06019E47 RID: 106055 RVA: 0x003C6A93 File Offset: 0x003C4C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Finish
		{
			get
			{
				return this.finish_;
			}
			set
			{
				this.finish_ = value;
			}
		}

		// Token: 0x06019E48 RID: 106056 RVA: 0x003C6A9C File Offset: 0x003C4C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSkipEntry);
		}

		// Token: 0x06019E49 RID: 106057 RVA: 0x003C6AAC File Offset: 0x003C4CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSkipEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnLock == other.UnLock && this.Finish == other.Finish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E4A RID: 106058 RVA: 0x003C6B08 File Offset: 0x003C4D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this.Finish)
			{
				num ^= this.Finish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E4B RID: 106059 RVA: 0x003C6B79 File Offset: 0x003C4D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E4C RID: 106060 RVA: 0x003C6B86 File Offset: 0x003C4D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E4D RID: 106061 RVA: 0x003C6B90 File Offset: 0x003C4D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnLock);
			}
			if (this.Finish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Finish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E4E RID: 106062 RVA: 0x003C6C04 File Offset: 0x003C4E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this.Finish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E4F RID: 106063 RVA: 0x003C6C5C File Offset: 0x003C4E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSkipEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			if (other.Finish)
			{
				this.Finish = other.Finish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E50 RID: 106064 RVA: 0x003C6CC0 File Offset: 0x003C4EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E51 RID: 106065 RVA: 0x003C6CCC File Offset: 0x003C4ECC
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Finish = input.ReadBool();
						}
					}
					else
					{
						this.UnLock = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098AB RID: 39083
		private static readonly MessageParser<SpringSkipEntry> _parser = new MessageParser<SpringSkipEntry>(() => new SpringSkipEntry());

		// Token: 0x040098AC RID: 39084
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098AD RID: 39085
		public const int IdFieldNumber = 1;

		// Token: 0x040098AE RID: 39086
		private int id_;

		// Token: 0x040098AF RID: 39087
		public const int UnLockFieldNumber = 2;

		// Token: 0x040098B0 RID: 39088
		private bool unLock_;

		// Token: 0x040098B1 RID: 39089
		public const int FinishFieldNumber = 3;

		// Token: 0x040098B2 RID: 39090
		private bool finish_;
	}
}
