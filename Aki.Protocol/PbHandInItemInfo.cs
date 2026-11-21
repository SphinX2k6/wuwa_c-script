using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF6 RID: 3062
	public sealed class PbHandInItemInfo : IMessage<PbHandInItemInfo>, IMessage, IEquatable<PbHandInItemInfo>, IDeepCloneable<PbHandInItemInfo>, IBufferMessage
	{
		// Token: 0x06010A53 RID: 68179 RVA: 0x00270685 File Offset: 0x0026E885
		[NullableContext(1)]
		public static PbHandInItemInfo Create()
		{
			return new PbHandInItemInfo();
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x06010A54 RID: 68180 RVA: 0x0027068C File Offset: 0x0026E88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbHandInItemInfo> Parser
		{
			get
			{
				return PbHandInItemInfo._parser;
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x06010A55 RID: 68181 RVA: 0x00270693 File Offset: 0x0026E893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x06010A56 RID: 68182 RVA: 0x00270696 File Offset: 0x0026E896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbHandInItemInfo.Descriptor;
			}
		}

		// Token: 0x06010A57 RID: 68183 RVA: 0x0027069D File Offset: 0x0026E89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo()
		{
		}

		// Token: 0x06010A58 RID: 68184 RVA: 0x002706A5 File Offset: 0x0026E8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo(PbHandInItemInfo other) : this()
		{
			this.incId_ = other.incId_;
			this.num_ = other.num_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A59 RID: 68185 RVA: 0x002706E2 File Offset: 0x0026E8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo Clone()
		{
			return new PbHandInItemInfo(this);
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x06010A5A RID: 68186 RVA: 0x002706EA File Offset: 0x0026E8EA
		// (set) Token: 0x06010A5B RID: 68187 RVA: 0x002706F2 File Offset: 0x0026E8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x06010A5C RID: 68188 RVA: 0x002706FB File Offset: 0x0026E8FB
		// (set) Token: 0x06010A5D RID: 68189 RVA: 0x00270703 File Offset: 0x0026E903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x06010A5E RID: 68190 RVA: 0x0027070C File Offset: 0x0026E90C
		// (set) Token: 0x06010A5F RID: 68191 RVA: 0x00270714 File Offset: 0x0026E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06010A60 RID: 68192 RVA: 0x0027071D File Offset: 0x0026E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbHandInItemInfo);
		}

		// Token: 0x06010A61 RID: 68193 RVA: 0x0027072C File Offset: 0x0026E92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbHandInItemInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Num == other.Num && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A62 RID: 68194 RVA: 0x00270788 File Offset: 0x0026E988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A63 RID: 68195 RVA: 0x002707F9 File Offset: 0x0026E9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A64 RID: 68196 RVA: 0x00270806 File Offset: 0x0026EA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A65 RID: 68197 RVA: 0x00270810 File Offset: 0x0026EA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A66 RID: 68198 RVA: 0x00270884 File Offset: 0x0026EA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A67 RID: 68199 RVA: 0x002708F4 File Offset: 0x0026EAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbHandInItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A68 RID: 68200 RVA: 0x00270958 File Offset: 0x0026EB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A69 RID: 68201 RVA: 0x00270964 File Offset: 0x0026EB64
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
							this.ItemId = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A3F RID: 27199
		private static readonly MessageParser<PbHandInItemInfo> _parser = new MessageParser<PbHandInItemInfo>(() => new PbHandInItemInfo());

		// Token: 0x04006A40 RID: 27200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A41 RID: 27201
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006A42 RID: 27202
		private int incId_;

		// Token: 0x04006A43 RID: 27203
		public const int NumFieldNumber = 2;

		// Token: 0x04006A44 RID: 27204
		private int num_;

		// Token: 0x04006A45 RID: 27205
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006A46 RID: 27206
		private int itemId_;
	}
}
