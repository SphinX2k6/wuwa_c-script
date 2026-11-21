using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A4 RID: 1956
	[NetMessage(EMessageId.HookLockPointInfoNotify)]
	public sealed class HookLockPointInfoNotify : IMessage<HookLockPointInfoNotify>, IMessage, IEquatable<HookLockPointInfoNotify>, IDeepCloneable<HookLockPointInfoNotify>, IBufferMessage
	{
		// Token: 0x0600B08F RID: 45199 RVA: 0x001A796D File Offset: 0x001A5B6D
		[NullableContext(1)]
		public static HookLockPointInfoNotify Create()
		{
			return new HookLockPointInfoNotify();
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600B090 RID: 45200 RVA: 0x001A7974 File Offset: 0x001A5B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x001A7977 File Offset: 0x001A5B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B092 RID: 45202 RVA: 0x001A797E File Offset: 0x001A5B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify()
		{
		}

		// Token: 0x0600B093 RID: 45203 RVA: 0x001A7986 File Offset: 0x001A5B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify(HookLockPointInfoNotify other) : this()
		{
			this.hookLockPointEntityId_ = other.hookLockPointEntityId_;
			this.isDisabled_ = other.isDisabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B094 RID: 45204 RVA: 0x001A79B7 File Offset: 0x001A5BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointInfoNotify Clone()
		{
			return new HookLockPointInfoNotify(this);
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600B095 RID: 45205 RVA: 0x001A79BF File Offset: 0x001A5BBF
		// (set) Token: 0x0600B096 RID: 45206 RVA: 0x001A79C7 File Offset: 0x001A5BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HookLockPointEntityId
		{
			get
			{
				return this.hookLockPointEntityId_;
			}
			set
			{
				this.hookLockPointEntityId_ = value;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600B097 RID: 45207 RVA: 0x001A79D0 File Offset: 0x001A5BD0
		// (set) Token: 0x0600B098 RID: 45208 RVA: 0x001A79D8 File Offset: 0x001A5BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisabled
		{
			get
			{
				return this.isDisabled_;
			}
			set
			{
				this.isDisabled_ = value;
			}
		}

		// Token: 0x0600B099 RID: 45209 RVA: 0x001A79E1 File Offset: 0x001A5BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointInfoNotify);
		}

		// Token: 0x0600B09A RID: 45210 RVA: 0x001A79EF File Offset: 0x001A5BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointInfoNotify other)
		{
			return other != null && (other == this || (this.HookLockPointEntityId == other.HookLockPointEntityId && this.IsDisabled == other.IsDisabled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B09B RID: 45211 RVA: 0x001A7A30 File Offset: 0x001A5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HookLockPointEntityId != 0L)
			{
				num ^= this.HookLockPointEntityId.GetHashCode();
			}
			if (this.IsDisabled)
			{
				num ^= this.IsDisabled.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B09C RID: 45212 RVA: 0x001A7A88 File Offset: 0x001A5C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B09D RID: 45213 RVA: 0x001A7A95 File Offset: 0x001A5C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B09E RID: 45214 RVA: 0x001A7AA0 File Offset: 0x001A5CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDisabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsDisabled);
			}
			if (this.HookLockPointEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.HookLockPointEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x001A7AFC File Offset: 0x001A5CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HookLockPointEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HookLockPointEntityId);
			}
			if (this.IsDisabled)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x001A7B48 File Offset: 0x001A5D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HookLockPointEntityId != 0L)
			{
				this.HookLockPointEntityId = other.HookLockPointEntityId;
			}
			if (other.IsDisabled)
			{
				this.IsDisabled = other.IsDisabled;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0A1 RID: 45217 RVA: 0x001A7B98 File Offset: 0x001A5D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0A2 RID: 45218 RVA: 0x001A7BA4 File Offset: 0x001A5DA4
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HookLockPointEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsDisabled = input.ReadBool();
				}
			}
		}

		// Token: 0x04004F9F RID: 20383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA0 RID: 20384
		public const int HookLockPointEntityIdFieldNumber = 11;

		// Token: 0x04004FA1 RID: 20385
		private long hookLockPointEntityId_;

		// Token: 0x04004FA2 RID: 20386
		public const int IsDisabledFieldNumber = 3;

		// Token: 0x04004FA3 RID: 20387
		private bool isDisabled_;
	}
}
