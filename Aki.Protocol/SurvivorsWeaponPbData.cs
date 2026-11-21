using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001364 RID: 4964
	public sealed class SurvivorsWeaponPbData : IMessage<SurvivorsWeaponPbData>, IMessage, IEquatable<SurvivorsWeaponPbData>, IDeepCloneable<SurvivorsWeaponPbData>, IBufferMessage
	{
		// Token: 0x0601A70D RID: 108301 RVA: 0x003DA5F6 File Offset: 0x003D87F6
		[NullableContext(1)]
		public static SurvivorsWeaponPbData Create()
		{
			return new SurvivorsWeaponPbData();
		}

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x0601A70E RID: 108302 RVA: 0x003DA5FD File Offset: 0x003D87FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x0601A70F RID: 108303 RVA: 0x003DA600 File Offset: 0x003D8800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponPbData.Descriptor;
			}
		}

		// Token: 0x0601A710 RID: 108304 RVA: 0x003DA607 File Offset: 0x003D8807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData()
		{
		}

		// Token: 0x0601A711 RID: 108305 RVA: 0x003DA60F File Offset: 0x003D880F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData(SurvivorsWeaponPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A712 RID: 108306 RVA: 0x003DA628 File Offset: 0x003D8828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData Clone()
		{
			return new SurvivorsWeaponPbData(this);
		}

		// Token: 0x0601A713 RID: 108307 RVA: 0x003DA630 File Offset: 0x003D8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponPbData);
		}

		// Token: 0x0601A714 RID: 108308 RVA: 0x003DA63E File Offset: 0x003D883E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x003DA65C File Offset: 0x003D885C
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

		// Token: 0x0601A716 RID: 108310 RVA: 0x003DA682 File Offset: 0x003D8882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A717 RID: 108311 RVA: 0x003DA68F File Offset: 0x003D888F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A718 RID: 108312 RVA: 0x003DA698 File Offset: 0x003D8898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A719 RID: 108313 RVA: 0x003DA6B0 File Offset: 0x003D88B0
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

		// Token: 0x0601A71A RID: 108314 RVA: 0x003DA6D6 File Offset: 0x003D88D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A71B RID: 108315 RVA: 0x003DA6F3 File Offset: 0x003D88F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A71C RID: 108316 RVA: 0x003DA6FC File Offset: 0x003D88FC
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

		// Token: 0x04009B26 RID: 39718
		private UnknownFieldSet _unknownFields;
	}
}
