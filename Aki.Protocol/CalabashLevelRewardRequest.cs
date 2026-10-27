using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021E RID: 542
	[NetMessage(EMessageId.CalabashLevelRewardRequest)]
	public sealed class CalabashLevelRewardRequest : IMessage<CalabashLevelRewardRequest>, IMessage, IEquatable<CalabashLevelRewardRequest>, IDeepCloneable<CalabashLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x06003B4A RID: 15178 RVA: 0x00093A37 File Offset: 0x00091C37
		[NullableContext(1)]
		public static CalabashLevelRewardRequest Create()
		{
			return new CalabashLevelRewardRequest();
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x00093A3E File Offset: 0x00091C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x00093A41 File Offset: 0x00091C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00093A48 File Offset: 0x00091C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest()
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00093A50 File Offset: 0x00091C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest(CalabashLevelRewardRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00093A75 File Offset: 0x00091C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelRewardRequest Clone()
		{
			return new CalabashLevelRewardRequest(this);
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00093A7D File Offset: 0x00091C7D
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x00093A85 File Offset: 0x00091C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00093A8E File Offset: 0x00091C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelRewardRequest);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00093A9C File Offset: 0x00091C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelRewardRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x00093ACC File Offset: 0x00091CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00093B0B File Offset: 0x00091D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00093B18 File Offset: 0x00091D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x00093B21 File Offset: 0x00091D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00093B54 File Offset: 0x00091D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x00093B92 File Offset: 0x00091D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00093BC3 File Offset: 0x00091DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00093BCC File Offset: 0x00091DCC
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
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C1F RID: 11295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C20 RID: 11296
		public const int LevelFieldNumber = 12;

		// Token: 0x04002C21 RID: 11297
		private int level_;
	}
}
