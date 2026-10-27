using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120E RID: 4622
	[NetMessage(EMessageId.ShortMessageUpdateRequest)]
	public sealed class ShortMessageUpdateRequest : IMessage<ShortMessageUpdateRequest>, IMessage, IEquatable<ShortMessageUpdateRequest>, IDeepCloneable<ShortMessageUpdateRequest>, IBufferMessage
	{
		// Token: 0x06018A26 RID: 100902 RVA: 0x0039514F File Offset: 0x0039334F
		[NullableContext(1)]
		public static ShortMessageUpdateRequest Create()
		{
			return new ShortMessageUpdateRequest();
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x06018A27 RID: 100903 RVA: 0x00395156 File Offset: 0x00393356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x06018A28 RID: 100904 RVA: 0x00395159 File Offset: 0x00393359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06018A29 RID: 100905 RVA: 0x00395160 File Offset: 0x00393360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest()
		{
		}

		// Token: 0x06018A2A RID: 100906 RVA: 0x00395168 File Offset: 0x00393368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest(ShortMessageUpdateRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.lastConfigId_ = other.lastConfigId_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A2B RID: 100907 RVA: 0x003951A5 File Offset: 0x003933A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest Clone()
		{
			return new ShortMessageUpdateRequest(this);
		}

		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x06018A2C RID: 100908 RVA: 0x003951AD File Offset: 0x003933AD
		// (set) Token: 0x06018A2D RID: 100909 RVA: 0x003951B5 File Offset: 0x003933B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x06018A2E RID: 100910 RVA: 0x003951BE File Offset: 0x003933BE
		// (set) Token: 0x06018A2F RID: 100911 RVA: 0x003951C6 File Offset: 0x003933C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastConfigId
		{
			get
			{
				return this.lastConfigId_;
			}
			set
			{
				this.lastConfigId_ = value;
			}
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x06018A30 RID: 100912 RVA: 0x003951CF File Offset: 0x003933CF
		// (set) Token: 0x06018A31 RID: 100913 RVA: 0x003951D7 File Offset: 0x003933D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06018A32 RID: 100914 RVA: 0x003951E0 File Offset: 0x003933E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateRequest);
		}

		// Token: 0x06018A33 RID: 100915 RVA: 0x003951F0 File Offset: 0x003933F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.LastConfigId == other.LastConfigId && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A34 RID: 100916 RVA: 0x0039524C File Offset: 0x0039344C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.LastConfigId != 0)
			{
				num ^= this.LastConfigId.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A35 RID: 100917 RVA: 0x003952BD File Offset: 0x003934BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A36 RID: 100918 RVA: 0x003952CA File Offset: 0x003934CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A37 RID: 100919 RVA: 0x003952D4 File Offset: 0x003934D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastConfigId);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A38 RID: 100920 RVA: 0x0039534C File Offset: 0x0039354C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastConfigId);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A39 RID: 100921 RVA: 0x003953B0 File Offset: 0x003935B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.LastConfigId != 0)
			{
				this.LastConfigId = other.LastConfigId;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A3A RID: 100922 RVA: 0x00395414 File Offset: 0x00393614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A3B RID: 100923 RVA: 0x00395420 File Offset: 0x00393620
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.IsFinish = input.ReadBool();
					}
				}
				else
				{
					this.LastConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400918C RID: 37260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400918D RID: 37261
		public const int ConfigIdFieldNumber = 12;

		// Token: 0x0400918E RID: 37262
		private int configId_;

		// Token: 0x0400918F RID: 37263
		public const int LastConfigIdFieldNumber = 2;

		// Token: 0x04009190 RID: 37264
		private int lastConfigId_;

		// Token: 0x04009191 RID: 37265
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04009192 RID: 37266
		private bool isFinish_;
	}
}
