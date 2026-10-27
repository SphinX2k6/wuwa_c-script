using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EF RID: 4847
	[NetMessage(EMessageId.SurvivorsVarRecordNotify)]
	public sealed class SurvivorsVarRecordNotify : IMessage<SurvivorsVarRecordNotify>, IMessage, IEquatable<SurvivorsVarRecordNotify>, IDeepCloneable<SurvivorsVarRecordNotify>, IBufferMessage
	{
		// Token: 0x06019C5E RID: 105566 RVA: 0x003BEE42 File Offset: 0x003BD042
		[NullableContext(1)]
		public static SurvivorsVarRecordNotify Create()
		{
			return new SurvivorsVarRecordNotify();
		}

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x06019C5F RID: 105567 RVA: 0x003BEE49 File Offset: 0x003BD049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x06019C60 RID: 105568 RVA: 0x003BEE4C File Offset: 0x003BD04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsVarRecordNotify.Descriptor;
			}
		}

		// Token: 0x06019C61 RID: 105569 RVA: 0x003BEE53 File Offset: 0x003BD053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify()
		{
		}

		// Token: 0x06019C62 RID: 105570 RVA: 0x003BEE66 File Offset: 0x003BD066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify(SurvivorsVarRecordNotify other) : this()
		{
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C63 RID: 105571 RVA: 0x003BEE90 File Offset: 0x003BD090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsVarRecordNotify Clone()
		{
			return new SurvivorsVarRecordNotify(this);
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x06019C64 RID: 105572 RVA: 0x003BEE98 File Offset: 0x003BD098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x06019C65 RID: 105573 RVA: 0x003BEEA0 File Offset: 0x003BD0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsVarRecordNotify);
		}

		// Token: 0x06019C66 RID: 105574 RVA: 0x003BEEAE File Offset: 0x003BD0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsVarRecordNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C67 RID: 105575 RVA: 0x003BEEE4 File Offset: 0x003BD0E4
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

		// Token: 0x06019C68 RID: 105576 RVA: 0x003BEF18 File Offset: 0x003BD118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C69 RID: 105577 RVA: 0x003BEF25 File Offset: 0x003BD125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C6A RID: 105578 RVA: 0x003BEF2E File Offset: 0x003BD12E
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

		// Token: 0x06019C6B RID: 105579 RVA: 0x003BEF58 File Offset: 0x003BD158
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

		// Token: 0x06019C6C RID: 105580 RVA: 0x003BEF91 File Offset: 0x003BD191
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

		// Token: 0x06019C6D RID: 105581 RVA: 0x003BEFBF File Offset: 0x003BD1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C6E RID: 105582 RVA: 0x003BEFC8 File Offset: 0x003BD1C8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.variableKeyNames_.AddEntriesFrom(ref input, SurvivorsVarRecordNotify._map_variableKeyNames_codec);
				}
			}
		}

		// Token: 0x040096D8 RID: 38616
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096D9 RID: 38617
		public const int VariableKeyNamesFieldNumber = 7;

		// Token: 0x040096DA RID: 38618
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 58U);

		// Token: 0x040096DB RID: 38619
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();
	}
}
