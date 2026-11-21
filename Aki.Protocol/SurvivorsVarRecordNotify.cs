using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135E RID: 4958
	[NetMessage(EMessageId.SurvivorsVarRecordNotify)]
	public sealed class SurvivorsVarRecordNotify : IMessage<SurvivorsVarRecordNotify>, IMessage, IEquatable<SurvivorsVarRecordNotify>, IDeepCloneable<SurvivorsVarRecordNotify>, IBufferMessage
	{
		// Token: 0x0601A694 RID: 108180 RVA: 0x003D9562 File Offset: 0x003D7762
		[NullableContext(1)]
		public static SurvivorsVarRecordNotify Create()
		{
			return new SurvivorsVarRecordNotify();
		}

		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x0601A695 RID: 108181 RVA: 0x003D9569 File Offset: 0x003D7769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x0601A696 RID: 108182 RVA: 0x003D956C File Offset: 0x003D776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsVarRecordNotify.Descriptor;
			}
		}

		// Token: 0x0601A697 RID: 108183 RVA: 0x003D9573 File Offset: 0x003D7773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify()
		{
		}

		// Token: 0x0601A698 RID: 108184 RVA: 0x003D9586 File Offset: 0x003D7786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify(SurvivorsVarRecordNotify other) : this()
		{
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A699 RID: 108185 RVA: 0x003D95B0 File Offset: 0x003D77B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify Clone()
		{
			return new SurvivorsVarRecordNotify(this);
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x0601A69A RID: 108186 RVA: 0x003D95B8 File Offset: 0x003D77B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x0601A69B RID: 108187 RVA: 0x003D95C0 File Offset: 0x003D77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsVarRecordNotify);
		}

		// Token: 0x0601A69C RID: 108188 RVA: 0x003D95CE File Offset: 0x003D77CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsVarRecordNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A69D RID: 108189 RVA: 0x003D9604 File Offset: 0x003D7804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.VariableKeyNames.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A69E RID: 108190 RVA: 0x003D9638 File Offset: 0x003D7838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A69F RID: 108191 RVA: 0x003D9645 File Offset: 0x003D7845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6A0 RID: 108192 RVA: 0x003D964E File Offset: 0x003D784E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.variableKeyNames_.WriteTo(ref output, SurvivorsVarRecordNotify._map_variableKeyNames_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6A1 RID: 108193 RVA: 0x003D9678 File Offset: 0x003D7878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.variableKeyNames_.CalculateSize(SurvivorsVarRecordNotify._map_variableKeyNames_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A6A2 RID: 108194 RVA: 0x003D96B1 File Offset: 0x003D78B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsVarRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.variableKeyNames_.MergeFrom(other.variableKeyNames_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6A3 RID: 108195 RVA: 0x003D96DF File Offset: 0x003D78DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6A4 RID: 108196 RVA: 0x003D96E8 File Offset: 0x003D78E8
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.variableKeyNames_.AddEntriesFrom(ref input, SurvivorsVarRecordNotify._map_variableKeyNames_codec);
				}
			}
		}

		// Token: 0x04009B02 RID: 39682
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B03 RID: 39683
		public const int VariableKeyNamesFieldNumber = 15;

		// Token: 0x04009B04 RID: 39684
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 122U);

		// Token: 0x04009B05 RID: 39685
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();
	}
}
