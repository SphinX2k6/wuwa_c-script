using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CD RID: 4301
	public sealed class RoleTowerLoadSubLevelStepPbData : IMessage<RoleTowerLoadSubLevelStepPbData>, IMessage, IEquatable<RoleTowerLoadSubLevelStepPbData>, IDeepCloneable<RoleTowerLoadSubLevelStepPbData>, IBufferMessage
	{
		// Token: 0x06016FD6 RID: 94166 RVA: 0x00357EB7 File Offset: 0x003560B7
		[NullableContext(1)]
		public static RoleTowerLoadSubLevelStepPbData Create()
		{
			return new RoleTowerLoadSubLevelStepPbData();
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x06016FD7 RID: 94167 RVA: 0x00357EBE File Offset: 0x003560BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x06016FD8 RID: 94168 RVA: 0x00357EC1 File Offset: 0x003560C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerLoadSubLevelStepPbData.Descriptor;
			}
		}

		// Token: 0x06016FD9 RID: 94169 RVA: 0x00357EC8 File Offset: 0x003560C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerLoadSubLevelStepPbData()
		{
		}

		// Token: 0x06016FDA RID: 94170 RVA: 0x00357EE6 File Offset: 0x003560E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerLoadSubLevelStepPbData(RoleTowerLoadSubLevelStepPbData other) : this()
		{
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FDB RID: 94171 RVA: 0x00357F21 File Offset: 0x00356121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerLoadSubLevelStepPbData Clone()
		{
			return new RoleTowerLoadSubLevelStepPbData(this);
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x06016FDC RID: 94172 RVA: 0x00357F29 File Offset: 0x00356129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x06016FDD RID: 94173 RVA: 0x00357F31 File Offset: 0x00356131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x06016FDE RID: 94174 RVA: 0x00357F39 File Offset: 0x00356139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerLoadSubLevelStepPbData);
		}

		// Token: 0x06016FDF RID: 94175 RVA: 0x00357F48 File Offset: 0x00356148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerLoadSubLevelStepPbData other)
		{
			return other != null && (other == this || (this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FE0 RID: 94176 RVA: 0x00357F9C File Offset: 0x0035619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.loadSubLevels_.GetHashCode();
			num ^= this.unLoadSubLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FE1 RID: 94177 RVA: 0x00357FDE File Offset: 0x003561DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FE2 RID: 94178 RVA: 0x00357FEB File Offset: 0x003561EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FE3 RID: 94179 RVA: 0x00357FF4 File Offset: 0x003561F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loadSubLevels_.WriteTo(ref output, RoleTowerLoadSubLevelStepPbData._repeated_loadSubLevels_codec);
			this.unLoadSubLevels_.WriteTo(ref output, RoleTowerLoadSubLevelStepPbData._repeated_unLoadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FE4 RID: 94180 RVA: 0x0035802C File Offset: 0x0035622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.loadSubLevels_.CalculateSize(RoleTowerLoadSubLevelStepPbData._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(RoleTowerLoadSubLevelStepPbData._repeated_unLoadSubLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FE5 RID: 94181 RVA: 0x00358078 File Offset: 0x00356278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerLoadSubLevelStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.loadSubLevels_.Add(other.loadSubLevels_);
			this.unLoadSubLevels_.Add(other.unLoadSubLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FE6 RID: 94182 RVA: 0x003580B7 File Offset: 0x003562B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FE7 RID: 94183 RVA: 0x003580C0 File Offset: 0x003562C0
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
				if (num != 58U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RoleTowerLoadSubLevelStepPbData._repeated_unLoadSubLevels_codec);
					}
				}
				else
				{
					this.loadSubLevels_.AddEntriesFrom(ref input, RoleTowerLoadSubLevelStepPbData._repeated_loadSubLevels_codec);
				}
			}
		}

		// Token: 0x04008997 RID: 35223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008998 RID: 35224
		public const int LoadSubLevelsFieldNumber = 7;

		// Token: 0x04008999 RID: 35225
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(58U);

		// Token: 0x0400899A RID: 35226
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x0400899B RID: 35227
		public const int UnLoadSubLevelsFieldNumber = 8;

		// Token: 0x0400899C RID: 35228
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(66U);

		// Token: 0x0400899D RID: 35229
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();
	}
}
