using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001188 RID: 4488
	public sealed class SceneFishCageInfo : IMessage<SceneFishCageInfo>, IMessage, IEquatable<SceneFishCageInfo>, IDeepCloneable<SceneFishCageInfo>, IBufferMessage
	{
		// Token: 0x06017F7F RID: 98175 RVA: 0x0037CED5 File Offset: 0x0037B0D5
		[NullableContext(1)]
		public static SceneFishCageInfo Create()
		{
			return new SceneFishCageInfo();
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x06017F80 RID: 98176 RVA: 0x0037CEDC File Offset: 0x0037B0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneFishCageInfo> Parser
		{
			get
			{
				return SceneFishCageInfo._parser;
			}
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x06017F81 RID: 98177 RVA: 0x0037CEE3 File Offset: 0x0037B0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x06017F82 RID: 98178 RVA: 0x0037CEE6 File Offset: 0x0037B0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishCageInfo.Descriptor;
			}
		}

		// Token: 0x06017F83 RID: 98179 RVA: 0x0037CEED File Offset: 0x0037B0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo()
		{
		}

		// Token: 0x06017F84 RID: 98180 RVA: 0x0037CF00 File Offset: 0x0037B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo(SceneFishCageInfo other) : this()
		{
			this.cages_ = other.cages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F85 RID: 98181 RVA: 0x0037CF2A File Offset: 0x0037B12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo Clone()
		{
			return new SceneFishCageInfo(this);
		}

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x06017F86 RID: 98182 RVA: 0x0037CF32 File Offset: 0x0037B132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishCage> Cages
		{
			get
			{
				return this.cages_;
			}
		}

		// Token: 0x06017F87 RID: 98183 RVA: 0x0037CF3A File Offset: 0x0037B13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishCageInfo);
		}

		// Token: 0x06017F88 RID: 98184 RVA: 0x0037CF48 File Offset: 0x0037B148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishCageInfo other)
		{
			return other != null && (other == this || (this.cages_.Equals(other.cages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F89 RID: 98185 RVA: 0x0037CF7C File Offset: 0x0037B17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F8A RID: 98186 RVA: 0x0037CFB0 File Offset: 0x0037B1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F8B RID: 98187 RVA: 0x0037CFBD File Offset: 0x0037B1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F8C RID: 98188 RVA: 0x0037CFC6 File Offset: 0x0037B1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cages_.WriteTo(ref output, SceneFishCageInfo._repeated_cages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F8D RID: 98189 RVA: 0x0037CFF0 File Offset: 0x0037B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cages_.CalculateSize(SceneFishCageInfo._repeated_cages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F8E RID: 98190 RVA: 0x0037D029 File Offset: 0x0037B229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneFishCageInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.cages_.Add(other.cages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F8F RID: 98191 RVA: 0x0037D057 File Offset: 0x0037B257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F90 RID: 98192 RVA: 0x0037D060 File Offset: 0x0037B260
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cages_.AddEntriesFrom(ref input, SceneFishCageInfo._repeated_cages_codec);
				}
			}
		}

		// Token: 0x04008EC6 RID: 36550
		private static readonly MessageParser<SceneFishCageInfo> _parser = new MessageParser<SceneFishCageInfo>(() => new SceneFishCageInfo());

		// Token: 0x04008EC7 RID: 36551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EC8 RID: 36552
		public const int CagesFieldNumber = 1;

		// Token: 0x04008EC9 RID: 36553
		private static readonly FieldCodec<OneFishCage> _repeated_cages_codec = FieldCodec.ForMessage<OneFishCage>(10U, OneFishCage.Parser);

		// Token: 0x04008ECA RID: 36554
		private readonly RepeatedField<OneFishCage> cages_ = new RepeatedField<OneFishCage>();
	}
}
