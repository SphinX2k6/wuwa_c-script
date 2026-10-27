using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DC RID: 4828
	public sealed class SurvivorsPrepareStepPbData : IMessage<SurvivorsPrepareStepPbData>, IMessage, IEquatable<SurvivorsPrepareStepPbData>, IDeepCloneable<SurvivorsPrepareStepPbData>, IBufferMessage
	{
		// Token: 0x06019AF7 RID: 105207 RVA: 0x003BC07A File Offset: 0x003BA27A
		[NullableContext(1)]
		public static SurvivorsPrepareStepPbData Create()
		{
			return new SurvivorsPrepareStepPbData();
		}

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x06019AF8 RID: 105208 RVA: 0x003BC081 File Offset: 0x003BA281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x06019AF9 RID: 105209 RVA: 0x003BC084 File Offset: 0x003BA284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsPrepareStepPbData.Descriptor;
			}
		}

		// Token: 0x06019AFA RID: 105210 RVA: 0x003BC08B File Offset: 0x003BA28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData()
		{
		}

		// Token: 0x06019AFB RID: 105211 RVA: 0x003BC093 File Offset: 0x003BA293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData(SurvivorsPrepareStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AFC RID: 105212 RVA: 0x003BC0AC File Offset: 0x003BA2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData Clone()
		{
			return new SurvivorsPrepareStepPbData(this);
		}

		// Token: 0x06019AFD RID: 105213 RVA: 0x003BC0B4 File Offset: 0x003BA2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsPrepareStepPbData);
		}

		// Token: 0x06019AFE RID: 105214 RVA: 0x003BC0C2 File Offset: 0x003BA2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsPrepareStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019AFF RID: 105215 RVA: 0x003BC0E0 File Offset: 0x003BA2E0
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

		// Token: 0x06019B00 RID: 105216 RVA: 0x003BC106 File Offset: 0x003BA306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B01 RID: 105217 RVA: 0x003BC113 File Offset: 0x003BA313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B02 RID: 105218 RVA: 0x003BC11C File Offset: 0x003BA31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B03 RID: 105219 RVA: 0x003BC134 File Offset: 0x003BA334
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

		// Token: 0x06019B04 RID: 105220 RVA: 0x003BC15A File Offset: 0x003BA35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsPrepareStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B05 RID: 105221 RVA: 0x003BC177 File Offset: 0x003BA377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B06 RID: 105222 RVA: 0x003BC180 File Offset: 0x003BA380
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

		// Token: 0x04009692 RID: 38546
		private UnknownFieldSet _unknownFields;
	}
}
