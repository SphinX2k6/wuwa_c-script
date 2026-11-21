using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001361 RID: 4961
	[NetMessage(EMessageId.SurvivorsWeaponInfoRequest)]
	public sealed class SurvivorsWeaponInfoRequest : IMessage<SurvivorsWeaponInfoRequest>, IMessage, IEquatable<SurvivorsWeaponInfoRequest>, IDeepCloneable<SurvivorsWeaponInfoRequest>, IBufferMessage
	{
		// Token: 0x0601A6D7 RID: 108247 RVA: 0x003D9FEA File Offset: 0x003D81EA
		[NullableContext(1)]
		public static SurvivorsWeaponInfoRequest Create()
		{
			return new SurvivorsWeaponInfoRequest();
		}

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x0601A6D8 RID: 108248 RVA: 0x003D9FF1 File Offset: 0x003D81F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x0601A6D9 RID: 108249 RVA: 0x003D9FF4 File Offset: 0x003D81F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601A6DA RID: 108250 RVA: 0x003D9FFB File Offset: 0x003D81FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest()
		{
		}

		// Token: 0x0601A6DB RID: 108251 RVA: 0x003DA003 File Offset: 0x003D8203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest(SurvivorsWeaponInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6DC RID: 108252 RVA: 0x003DA01C File Offset: 0x003D821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest Clone()
		{
			return new SurvivorsWeaponInfoRequest(this);
		}

		// Token: 0x0601A6DD RID: 108253 RVA: 0x003DA024 File Offset: 0x003D8224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponInfoRequest);
		}

		// Token: 0x0601A6DE RID: 108254 RVA: 0x003DA032 File Offset: 0x003D8232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A6DF RID: 108255 RVA: 0x003DA050 File Offset: 0x003D8250
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

		// Token: 0x0601A6E0 RID: 108256 RVA: 0x003DA076 File Offset: 0x003D8276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6E1 RID: 108257 RVA: 0x003DA083 File Offset: 0x003D8283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6E2 RID: 108258 RVA: 0x003DA08C File Offset: 0x003D828C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6E3 RID: 108259 RVA: 0x003DA0A4 File Offset: 0x003D82A4
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

		// Token: 0x0601A6E4 RID: 108260 RVA: 0x003DA0CA File Offset: 0x003D82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6E5 RID: 108261 RVA: 0x003DA0E7 File Offset: 0x003D82E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6E6 RID: 108262 RVA: 0x003DA0F0 File Offset: 0x003D82F0
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

		// Token: 0x04009B1C RID: 39708
		private UnknownFieldSet _unknownFields;
	}
}
