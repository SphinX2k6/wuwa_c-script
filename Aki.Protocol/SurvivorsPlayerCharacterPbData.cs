using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DB RID: 4827
	public sealed class SurvivorsPlayerCharacterPbData : IMessage<SurvivorsPlayerCharacterPbData>, IMessage, IEquatable<SurvivorsPlayerCharacterPbData>, IDeepCloneable<SurvivorsPlayerCharacterPbData>, IBufferMessage
	{
		// Token: 0x06019AE7 RID: 105191 RVA: 0x003BBF40 File Offset: 0x003BA140
		[NullableContext(1)]
		public static SurvivorsPlayerCharacterPbData Create()
		{
			return new SurvivorsPlayerCharacterPbData();
		}

		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x06019AE8 RID: 105192 RVA: 0x003BBF47 File Offset: 0x003BA147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x06019AE9 RID: 105193 RVA: 0x003BBF4A File Offset: 0x003BA14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsPlayerCharacterPbData.Descriptor;
			}
		}

		// Token: 0x06019AEA RID: 105194 RVA: 0x003BBF51 File Offset: 0x003BA151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData()
		{
		}

		// Token: 0x06019AEB RID: 105195 RVA: 0x003BBF59 File Offset: 0x003BA159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData(SurvivorsPlayerCharacterPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AEC RID: 105196 RVA: 0x003BBF72 File Offset: 0x003BA172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData Clone()
		{
			return new SurvivorsPlayerCharacterPbData(this);
		}

		// Token: 0x06019AED RID: 105197 RVA: 0x003BBF7A File Offset: 0x003BA17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsPlayerCharacterPbData);
		}

		// Token: 0x06019AEE RID: 105198 RVA: 0x003BBF88 File Offset: 0x003BA188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsPlayerCharacterPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019AEF RID: 105199 RVA: 0x003BBFA8 File Offset: 0x003BA1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AF0 RID: 105200 RVA: 0x003BBFCE File Offset: 0x003BA1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AF1 RID: 105201 RVA: 0x003BBFDB File Offset: 0x003BA1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AF2 RID: 105202 RVA: 0x003BBFE4 File Offset: 0x003BA1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AF3 RID: 105203 RVA: 0x003BBFFC File Offset: 0x003BA1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019AF4 RID: 105204 RVA: 0x003BC022 File Offset: 0x003BA222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsPlayerCharacterPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019AF5 RID: 105205 RVA: 0x003BC03F File Offset: 0x003BA23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AF6 RID: 105206 RVA: 0x003BC048 File Offset: 0x003BA248
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009691 RID: 38545
		private UnknownFieldSet _unknownFields;
	}
}
