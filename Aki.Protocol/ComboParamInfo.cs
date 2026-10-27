using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B7 RID: 695
	public sealed class ComboParamInfo : IMessage<ComboParamInfo>, IMessage, IEquatable<ComboParamInfo>, IDeepCloneable<ComboParamInfo>, IBufferMessage
	{
		// Token: 0x060047D0 RID: 18384 RVA: 0x000B05A4 File Offset: 0x000AE7A4
		[NullableContext(1)]
		public static ComboParamInfo Create()
		{
			return new ComboParamInfo();
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x000B05AB File Offset: 0x000AE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComboParamInfo> Parser
		{
			get
			{
				return ComboParamInfo._parser;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x000B05B2 File Offset: 0x000AE7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x000B05B5 File Offset: 0x000AE7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComboParamInfo.Descriptor;
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x000B05BC File Offset: 0x000AE7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo()
		{
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000B05C4 File Offset: 0x000AE7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo(ComboParamInfo other) : this()
		{
			this.keepTime_ = other.keepTime_;
			this.addTime_ = other.addTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x000B05F5 File Offset: 0x000AE7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo Clone()
		{
			return new ComboParamInfo(this);
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x000B05FD File Offset: 0x000AE7FD
		// (set) Token: 0x060047D8 RID: 18392 RVA: 0x000B0605 File Offset: 0x000AE805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepTime
		{
			get
			{
				return this.keepTime_;
			}
			set
			{
				this.keepTime_ = value;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x000B060E File Offset: 0x000AE80E
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x000B0616 File Offset: 0x000AE816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddTime
		{
			get
			{
				return this.addTime_;
			}
			set
			{
				this.addTime_ = value;
			}
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x000B061F File Offset: 0x000AE81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComboParamInfo);
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x000B062D File Offset: 0x000AE82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComboParamInfo other)
		{
			return other != null && (other == this || (this.KeepTime == other.KeepTime && this.AddTime == other.AddTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x000B066C File Offset: 0x000AE86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KeepTime != 0)
			{
				num ^= this.KeepTime.GetHashCode();
			}
			if (this.AddTime != 0)
			{
				num ^= this.AddTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x000B06C4 File Offset: 0x000AE8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x000B06D1 File Offset: 0x000AE8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x000B06DC File Offset: 0x000AE8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KeepTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.KeepTime);
			}
			if (this.AddTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x000B0734 File Offset: 0x000AE934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KeepTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepTime);
			}
			if (this.AddTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x000B078C File Offset: 0x000AE98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComboParamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KeepTime != 0)
			{
				this.KeepTime = other.KeepTime;
			}
			if (other.AddTime != 0)
			{
				this.AddTime = other.AddTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x000B07DC File Offset: 0x000AE9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000B07E8 File Offset: 0x000AE9E8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AddTime = input.ReadInt32();
					}
				}
				else
				{
					this.KeepTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002FBE RID: 12222
		private static readonly MessageParser<ComboParamInfo> _parser = new MessageParser<ComboParamInfo>(() => new ComboParamInfo());

		// Token: 0x04002FBF RID: 12223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC0 RID: 12224
		public const int KeepTimeFieldNumber = 1;

		// Token: 0x04002FC1 RID: 12225
		private int keepTime_;

		// Token: 0x04002FC2 RID: 12226
		public const int AddTimeFieldNumber = 2;

		// Token: 0x04002FC3 RID: 12227
		private int addTime_;
	}
}
