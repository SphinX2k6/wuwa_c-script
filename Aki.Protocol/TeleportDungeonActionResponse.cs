using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001337 RID: 4919
	[NetMessage(EMessageId.TeleportDungeonActionResponse)]
	public sealed class TeleportDungeonActionResponse : IMessage<TeleportDungeonActionResponse>, IMessage, IEquatable<TeleportDungeonActionResponse>, IDeepCloneable<TeleportDungeonActionResponse>, IBufferMessage
	{
		// Token: 0x0601A229 RID: 107049 RVA: 0x003CBD3A File Offset: 0x003C9F3A
		[NullableContext(1)]
		public static TeleportDungeonActionResponse Create()
		{
			return new TeleportDungeonActionResponse();
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x0601A22A RID: 107050 RVA: 0x003CBD41 File Offset: 0x003C9F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x0601A22B RID: 107051 RVA: 0x003CBD44 File Offset: 0x003C9F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionResponse.Descriptor;
			}
		}

		// Token: 0x0601A22C RID: 107052 RVA: 0x003CBD4B File Offset: 0x003C9F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse()
		{
		}

		// Token: 0x0601A22D RID: 107053 RVA: 0x003CBD53 File Offset: 0x003C9F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse(TeleportDungeonActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A22E RID: 107054 RVA: 0x003CBD78 File Offset: 0x003C9F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse Clone()
		{
			return new TeleportDungeonActionResponse(this);
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x0601A22F RID: 107055 RVA: 0x003CBD80 File Offset: 0x003C9F80
		// (set) Token: 0x0601A230 RID: 107056 RVA: 0x003CBD88 File Offset: 0x003C9F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601A231 RID: 107057 RVA: 0x003CBD91 File Offset: 0x003C9F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionResponse);
		}

		// Token: 0x0601A232 RID: 107058 RVA: 0x003CBD9F File Offset: 0x003C9F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A233 RID: 107059 RVA: 0x003CBDD0 File Offset: 0x003C9FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A234 RID: 107060 RVA: 0x003CBE15 File Offset: 0x003CA015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A235 RID: 107061 RVA: 0x003CBE22 File Offset: 0x003CA022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A236 RID: 107062 RVA: 0x003CBE2B File Offset: 0x003CA02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A237 RID: 107063 RVA: 0x003CBE60 File Offset: 0x003CA060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A238 RID: 107064 RVA: 0x003CBE9E File Offset: 0x003CA09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A239 RID: 107065 RVA: 0x003CBECF File Offset: 0x003CA0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A23A RID: 107066 RVA: 0x003CBED8 File Offset: 0x003CA0D8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400988A RID: 39050
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400988B RID: 39051
		public const int CodeFieldNumber = 6;

		// Token: 0x0400988C RID: 39052
		private ErrorCode code_;
	}
}
