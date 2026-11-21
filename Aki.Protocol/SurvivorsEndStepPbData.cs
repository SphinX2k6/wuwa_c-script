using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001334 RID: 4916
	public sealed class SurvivorsEndStepPbData : IMessage<SurvivorsEndStepPbData>, IMessage, IEquatable<SurvivorsEndStepPbData>, IDeepCloneable<SurvivorsEndStepPbData>, IBufferMessage
	{
		// Token: 0x0601A349 RID: 107337 RVA: 0x003D1C5A File Offset: 0x003CFE5A
		[NullableContext(1)]
		public static SurvivorsEndStepPbData Create()
		{
			return new SurvivorsEndStepPbData();
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x0601A34A RID: 107338 RVA: 0x003D1C61 File Offset: 0x003CFE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x0601A34B RID: 107339 RVA: 0x003D1C64 File Offset: 0x003CFE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsEndStepPbData.Descriptor;
			}
		}

		// Token: 0x0601A34C RID: 107340 RVA: 0x003D1C6B File Offset: 0x003CFE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData()
		{
		}

		// Token: 0x0601A34D RID: 107341 RVA: 0x003D1C73 File Offset: 0x003CFE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData(SurvivorsEndStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A34E RID: 107342 RVA: 0x003D1C8C File Offset: 0x003CFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData Clone()
		{
			return new SurvivorsEndStepPbData(this);
		}

		// Token: 0x0601A34F RID: 107343 RVA: 0x003D1C94 File Offset: 0x003CFE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsEndStepPbData);
		}

		// Token: 0x0601A350 RID: 107344 RVA: 0x003D1CA2 File Offset: 0x003CFEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsEndStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A351 RID: 107345 RVA: 0x003D1CC0 File Offset: 0x003CFEC0
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

		// Token: 0x0601A352 RID: 107346 RVA: 0x003D1CE6 File Offset: 0x003CFEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A353 RID: 107347 RVA: 0x003D1CF3 File Offset: 0x003CFEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A354 RID: 107348 RVA: 0x003D1CFC File Offset: 0x003CFEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A355 RID: 107349 RVA: 0x003D1D14 File Offset: 0x003CFF14
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

		// Token: 0x0601A356 RID: 107350 RVA: 0x003D1D3A File Offset: 0x003CFF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsEndStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A357 RID: 107351 RVA: 0x003D1D57 File Offset: 0x003CFF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A358 RID: 107352 RVA: 0x003D1D60 File Offset: 0x003CFF60
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

		// Token: 0x04009A26 RID: 39462
		private UnknownFieldSet _unknownFields;
	}
}
