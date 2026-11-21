using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EB RID: 1003
	[NetMessage(EMessageId.DressPlayerTitleUpdateNotify)]
	public sealed class DressPlayerTitleUpdateNotify : IMessage<DressPlayerTitleUpdateNotify>, IMessage, IEquatable<DressPlayerTitleUpdateNotify>, IDeepCloneable<DressPlayerTitleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600617F RID: 24959 RVA: 0x000EB4E4 File Offset: 0x000E96E4
		[NullableContext(1)]
		public static DressPlayerTitleUpdateNotify Create()
		{
			return new DressPlayerTitleUpdateNotify();
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x000EB4EB File Offset: 0x000E96EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x000EB4EE File Offset: 0x000E96EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressPlayerTitleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x000EB4F5 File Offset: 0x000E96F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify()
		{
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x000EB4FD File Offset: 0x000E96FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify(DressPlayerTitleUpdateNotify other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this.playerTitleExtraParam_ = other.playerTitleExtraParam_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x000EB52E File Offset: 0x000E972E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify Clone()
		{
			return new DressPlayerTitleUpdateNotify(this);
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x000EB536 File Offset: 0x000E9736
		// (set) Token: 0x06006186 RID: 24966 RVA: 0x000EB53E File Offset: 0x000E973E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06006187 RID: 24967 RVA: 0x000EB547 File Offset: 0x000E9747
		// (set) Token: 0x06006188 RID: 24968 RVA: 0x000EB54F File Offset: 0x000E974F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleExtraParam
		{
			get
			{
				return this.playerTitleExtraParam_;
			}
			set
			{
				this.playerTitleExtraParam_ = value;
			}
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x000EB558 File Offset: 0x000E9758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressPlayerTitleUpdateNotify);
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x000EB566 File Offset: 0x000E9766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressPlayerTitleUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x000EB5A4 File Offset: 0x000E97A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num ^= this.PlayerTitleExtraParam.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x000EB5FC File Offset: 0x000E97FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x000EB609 File Offset: 0x000E9809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x000EB614 File Offset: 0x000E9814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerTitleExtraParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x000EB670 File Offset: 0x000E9870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleExtraParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x000EB6C8 File Offset: 0x000E98C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressPlayerTitleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			if (other.PlayerTitleExtraParam != 0)
			{
				this.PlayerTitleExtraParam = other.PlayerTitleExtraParam;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x000EB718 File Offset: 0x000E9918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x000EB724 File Offset: 0x000E9924
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerTitleExtraParam = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerTitleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037F5 RID: 14325
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037F6 RID: 14326
		public const int PlayerTitleIdFieldNumber = 5;

		// Token: 0x040037F7 RID: 14327
		private int playerTitleId_;

		// Token: 0x040037F8 RID: 14328
		public const int PlayerTitleExtraParamFieldNumber = 11;

		// Token: 0x040037F9 RID: 14329
		private int playerTitleExtraParam_;
	}
}
